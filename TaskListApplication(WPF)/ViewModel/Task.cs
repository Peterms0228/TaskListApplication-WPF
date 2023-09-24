using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskListApplication_WPF_.Enums;

namespace TaskListApplication_WPF_.ViewModel
{
    class Task
    {
        private string name;
        private DateTime dueDate;
        private Status status;

        //Constructor
        public Task()
        {
            this.status = Status.Pending;
        }
        public Task(string name, DateTime dueDate, Status status)
        {
            this.name = name;
            this.dueDate = dueDate;
            this.status = status;
        }

        //Getter & Setter
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public Status Status
        {
            get { return status; }
            set { status = value; }
        }
        
    }
}
