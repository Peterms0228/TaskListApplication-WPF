using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskListApplication_WPF_.ViewModel;

namespace TaskListApplication_WPF_.Command
{
    class CreateTaskCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is TaskViewModel taskList)
            {
                taskList.Tasks.Add(new ViewModel.Task(
                    taskList.TaskName, 
                    taskList.TaskDueDate,
                    //DateTime.Parse(taskList.TaskDueDate.ToString(format: Settings.Formats.dateFormat)), 
                    Enums.Status.Pending 
                    ));
            }
        }
    }
}
