﻿using GalaSoft.MvvmLight.Messaging;
using OSKernel.Presentation.Arranging.Mixed.Modify.Rule.ClassHour.Model;
using OSKernel.Presentation.Arranging.Mixed.Modify.Rule.Teacher.Model;
using OSKernel.Presentation.Core;
using OSKernel.Presentation.Core.ViewModel;
using OSKernel.Presentation.CustomControl;
using OSKernel.Presentation.Models.Enums;
using OSKernel.Presentation.Models.Rule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Unity;

namespace OSKernel.Presentation.Arranging.Mixed.Modify.Rule.ClassHour
{
    public class ClassHourAverageViewModel : CommonViewModel, IInitilize
    {
        private int _batchMinDay;

        private bool _isAllChecked;

        private List<UIClassHourAverage> _rules;

        public ICommand UserControlCommand
        {
            get
            {
                return new GalaSoft.MvvmLight.Command.RelayCommand<string>(userControlCommand);
            }
        }

        public List<UIClassHourAverage> Rules
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

        public bool IsAllChecked
        {
            get
            {
                return _isAllChecked;
            }

            set
            {
                _isAllChecked = value;
                RaisePropertyChanged(() => IsAllChecked);

                this.Rules?.ForEach(r =>
                {
                    r.IsChecked = value;
                });

            }
        }

        /// <summary>
        /// 最小天数
        /// </summary>
        public int BatchMinDay
        {
            get
            {
                return _batchMinDay;
            }

            set
            {
                _batchMinDay = value;
                RaisePropertyChanged(() => BatchMinDay);

                this.Rules.ForEach(r => r.MinDay = value);
            }
        }

        public ClassHourAverageViewModel()
        {
            this.Rules = new List<UIClassHourAverage>();

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

            this.Comments = CommonDataManager.GetMixedRuleComments(MixedRuleEnum.ClassHourAverage);

            var cl = base.GetClCase(base.LocalID);
            // 绑定
            int no = 0;
            List<UIClassHourAverage> rules = new List<UIClassHourAverage>();
            cl.Classes.ForEach(t =>
            {
                var courses = cl.GetCoursesByClassID(t.ID);
                courses.ForEach(c =>
                {
                    UIClassHourAverage teacherRule = new UIClassHourAverage()
                    {
                        NO = ++no,
                        MinDay = 1,
                        ClassID = t.ID,
                        LevelID = t.LevelID,
                        CourseID = c.ID,
                        Course = c.Name
                    };

                    var first = cl.Courses.FirstOrDefault(course => course.ID.Equals(c.ID));
                    if (first != null)
                    {
                        var level = first.Levels.FirstOrDefault(l => l.ID.Equals(t.LevelID));
                        var classModel = cl.Classes.FirstOrDefault(cc => cc.ID.Equals(t.ID));

                        if (string.IsNullOrEmpty(level.ID))
                        {
                            teacherRule.ClassName = classModel.Name;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(level.Name))
                            {
                                teacherRule.ClassName = classModel.Name;
                            }
                            else
                            {
                                teacherRule.ClassName = $"{level.Name}-{classModel.Name}";
                            }

                        }
                    }

                    rules.Add(teacherRule);
                });
            });
            this.Rules = rules;

            // 绑定状态
            var rule = base.GetClRule(base.LocalID);
            if (rule != null)
            {
                rule.ClassHourAverages.ForEach(h =>
                {
                    var first = this.Rules.FirstOrDefault(r => r.ClassID.Equals(h.ClassID));
                    if (first != null)
                    {
                        first.IsActive = true;
                        first.MinDay = h.MinDay;
                        first.Weight = (Models.Enums.WeightTypeEnum)h.Weight;
                        first.IsChecked = true;
                    }
                });
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

        void save(HostView host)
        {
            var rule = base.GetClRule(base.LocalID);

            rule.ClassHourAverages.Clear();

            this.Rules.Where(r => r.IsChecked)?.ToList()?.ForEach(r =>
            {
                var average = new XYKernel.OS.Common.Models.Mixed.Rule.ClassHourAverageRule()
                {
                    ClassID = r.ClassID,
                    MinDay = r.MinDay,
                    Weight = (int)r.Weight
                };
                rule.ClassHourAverages.Add(average);

            });

            base.SerializePatternRule(rule, base.LocalID);
            this.ShowDialog("提示信息", "保存成功", CustomControl.Enums.DialogSettingType.NoButton, CustomControl.Enums.DialogType.None);
        }

        public override void BatchSetWeight(WeightTypeEnum weightEnum)
        {
            this.Rules.ForEach(r =>
            {
                r.Weight = weightEnum;
            });
        }
    }
}
