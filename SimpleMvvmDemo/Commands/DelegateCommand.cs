using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleMvvmDemo.Commands
{
    internal class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (this.CanExcuteFunc==null)
            {
                return true;
            }

            return this.CanExcuteFunc(parameter);
        }

        public void Execute(object parameter)
        {
            if (this.ExecuteAction==null)
            {
                return;
            }
            
            this.ExecuteAction(parameter);
        }

        public Action<object> ExecuteAction { get; set; }
        public Func<Object,bool> CanExcuteFunc { get; set; }
    }
}
