using System;
using System.Windows.Input;

namespace BilletSystem_EksamensProjekt
{
    public abstract class CommandBase : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MyExecute();
        }

        public event EventHandler CanExecuteChanged;

        public abstract void MyExecute();
    }
}