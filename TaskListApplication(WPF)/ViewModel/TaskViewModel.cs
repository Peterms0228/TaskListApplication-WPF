using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskListApplication_WPF_.Command;

namespace TaskListApplication_WPF_.ViewModel
{
    class TaskViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Task> tasks = new ObservableCollection<Task>();
        public ObservableCollection<Task> Tasks 
        { 
            get { return tasks; } 
            set {
                if(tasks != value)
                {
                    tasks = value;
                    NotifyPropertyChanged(nameof(Tasks));
                }
            } 
        }
        public string TaskName { get; set; }        
        public DateTime TaskDueDate { get; set; }

        public ICommand CreateTaskCommand { get { return new CreateTaskCommand(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
