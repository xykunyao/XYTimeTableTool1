﻿using System;
using System.Windows.Input;

namespace XYTimeTableTools.Update
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            return;
        }
    }
}
