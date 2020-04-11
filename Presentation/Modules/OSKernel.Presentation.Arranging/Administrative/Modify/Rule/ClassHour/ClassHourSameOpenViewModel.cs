﻿using GalaSoft.MvvmLight.Messaging;
using OSKernel.Presentation.Arranging.Administrative.Modify.Rule.ClassHour.Dialog;
using OSKernel.Presentation.Arranging.Administrative.Modify.Rule.ClassHour.Model;
using OSKernel.Presentation.Arranging.Administrative.Modify.Rule.Course.Model;
using OSKernel.Presentation.Arranging.Administrative.Modify.Rule.Teacher.Dialog;
using OSKernel.Presentation.Core;
using OSKernel.Presentation.Core.ViewModel;
using OSKernel.Presentation.CustomControl;
using OSKernel.Presentation.Models.Enums;
using OSKernel.Presentation.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Unity;
using XYKernel.OS.Common.Models.Administrative.Rule;

namespace OSKernel.Presentation.Arranging.Administrative.Modify.Rule.ClassHour
{
    public class ClassHourSameOpenViewModel : CommonViewModel, IInitilize
    {
        private ObservableCollection<UISameOpenTime> _rules;

        public ICommand UserControlCommand
        {
            get
            {
                return new GalaSoft.MvvmLight.Command.RelayCommand<string>(userControlCommand);
            }
        }

        public ICommand CreateCommand
        {
            get
            {
                return new GalaSoft.MvvmLight.Command.RelayCommand(createCommand);
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                return new GalaSoft.MvvmLight.Command.RelayCommand<object>(deleteCommand);
            }
        }

        public ICommand ModifyCommand
        {
            get
            {
                return new GalaSoft.MvvmLight.Command.RelayCommand<object>(modifyCommand);
            }
        }

        public ObservableCollection<UISameOpenTime> Rules
        {
            get
            {
                return _rules;
            }

            set
            {
                _rules = value;
                RaisePropertyChanged(() => Rules);
            }
        }

        public ClassHourSameOpenViewModel()
        {
            this.Rules = new ObservableCollection<UISameOpenTime>();

            base.Weights = new Dictionary<string, WeightTypeEnum>()
            {
                { "高", WeightTypeEnum.Hight},
                { "中", WeightTypeEnum.Medium},
                { "低", WeightTypeEnum.Low},
            };

            base.SelectWeight = WeightTypeEnum.Hight;
        }

        [InjectionMethod]
        public void Initilize()
        {
            Messenger.Default.Register<HostView>(this, save);

            this.Comments = CommonDataManager.GetAdminRuleComments(AdministrativeRuleEnum.ClassHourSameOpen);


            var rule = CommonDataManager.GetAminRule(base.LocalID);
            if (rule.ClassHourSameOpens?.Count > 0)
            {
                var temp = Models.Enums.AdministrativeRuleEnum.ClassHourSameOpen.RuleDeSerialize<ObservableCollection<UISameOpenTime>>(base.LocalID);
                if (temp != null)
                {
                    this.Rules = temp;
                }
            }
        }

        void userControlCommand(string parms)
        {
            if (parms.Equals("loaded"))
            {

            }
            else if (parms.Equals("unloaded"))
            {
                Messenger.Default.Unregister<HostView>(this, save);
            }
        }

        void createCommand()
        {
            CreateClassHourSameOpenView win = new CreateClassHourSameOpenView();
            win.Closed += (s, arg) =>
            {
                if (win.DialogResult.Value)
                {
                    var last = this.Rules.LastOrDefault();
                    var index = last == null ? 0 : last.NO;

                    var rule = new UISameOpenTime()
                    {
                        NO = index + 1,
                        Classes = win.Classes,
                    };

                    var cp = CommonDataManager.GetCPCase(base.LocalID);

                    var details = new XYKernel.OS.Common.Models.Administrative.Rule.SameOpenDetailsModel();
                    rule.Classes.ForEach(c =>
                    {
                        var hours = cp.GetClassHours(c.CourseID, c.ID);
                        if (hours?.Count > 0)
                        {
                            for (int i = 0; i < hours?.Count; i++)
                            {
                                c.HourIndexs.Add(new Models.Administrative.UIClassHourIndex()
                                {
                                    Index = i,
                                    IsChecked = true
                                });
                            }
                        }

                    });

                    this.Rules.Add(rule);
                }
            };
            win.ShowDialog();
        }

        void modifyCommand(object obj)
        {
            UISameOpenTime model = obj as UISameOpenTime;

            ModifyClassHourSameOpen modify = new ModifyClassHourSameOpen(model.Classes);
            modify.Closed += (s, arg) =>
            {
                if (modify.DialogResult.Value)
                {
                    model.Classes = modify.Classes;
                }
            };
            modify.ShowDialog();
        }

        void deleteCommand(object obj)
        {
            var result = this.ShowDialog("提示信息", "确定删除?", CustomControl.Enums.DialogSettingType.OkAndCancel, CustomControl.Enums.DialogType.Warning);
            if (result == CustomControl.Enums.DialogResultType.OK)
            {
                var model = obj as UISameOpenTime;
                this.Rules.Remove(model);
            }
        }

        void save(HostView host)
        {
            var rule = CommonDataManager.GetAminRule(base.LocalID);

            // 1.清除同时开课规则
            rule.ClassHourSameOpens.Clear();

            if (this.Rules != null)
            {
                foreach (var r in this.Rules)
                {
                    var samopenRule = new XYKernel.OS.Common.Models.Administrative.Rule.ClassHourSameOpenRule()
                    {
                        Details = new List<XYKernel.OS.Common.Models.Administrative.Rule.SameOpenDetailsModel>(),
                        Weight = (int)r.Weight
                    };

                    var maxIndex = r.Classes.Max(c => c.HourIndexs.Count);

                    // 遍历填充详细
                    for (int i = 0; i < maxIndex; i++)
                    {
                        var item = new XYKernel.OS.Common.Models.Administrative.Rule.SameOpenDetailsModel();
                        item.Index = i;
                        item.Classes = new List<CourseClassModel>();

                        // 过滤选中班级
                        r.Classes.ForEach(c =>
                        {
                            if (c.HourIndexs.Count >= i + 1)
                            {
                                if (c.HourIndexs[i].IsChecked)
                                {
                                    CourseClassModel classModel = new CourseClassModel()
                                    {
                                        ClassID = c.ID,
                                        CourseID = c.CourseID
                                    };
                                    item.Classes.Add(classModel);
                                }
                            }
                        });

                        if (item.Classes.Count > 1)
                            samopenRule.Details.Add(item);
                    }

                    rule.ClassHourSameOpens.Add(samopenRule);
                }
            }

            // 2.序列化
            rule.Serialize(base.LocalID);

            // 3.弹出提示
            this.ShowDialog("提示信息", "保存成功", CustomControl.Enums.DialogSettingType.NoButton, CustomControl.Enums.DialogType.None);

            // 4.序列化规则
            OSKernel.Presentation.Models.Enums.AdministrativeRuleEnum.ClassHourSameOpen.RuleSerialize(base.LocalID, this.Rules);
        }

        public override void BatchSetWeight(WeightTypeEnum weightEnum)
        {
            foreach (var r in this.Rules)
            {
                r.Weight = weightEnum;
            }
        }
    }
}
