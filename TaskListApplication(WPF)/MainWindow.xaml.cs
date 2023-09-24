using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TaskListApplication_WPF_.Enums;
using TaskListApplication_WPF_.ViewModel;

namespace TaskListApplication_WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var tasks = new TaskViewModel();
            tasks.TaskDueDate = DateTime.Now;
            tasks.Tasks.Add(new ViewModel.Task("Task 1", DateTime.Now.AddDays(5), Status.Pending ));
            tasks.Tasks.Add(new ViewModel.Task("Task 2", DateTime.Now.AddDays(3), Status.Completed ));
            this.DataContext = tasks;
        }
    }
}
