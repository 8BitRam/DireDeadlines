using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region INotifyPropertyChanged Namespaces
using System.ComponentModel;
using System.Runtime.CompilerServices;
#endregion

namespace DireDeadlines
{
    internal class Job : INotifyPropertyChanged
    {
        //Private Member Variables
        private int jobId;
        
        private string title;
        private string description;
        
        private string toDoContent;
        private string doingContent;
        private string doneContent;
        
        private Stopwatch timer;
        
        private string reward;
        private string punishment;
        
        private DateTime creationDate;
        private DateTime deadline;

        private List<Job> subJobs = new List<Job>();
        //Public Member Variables
        public int JobId
        {
            get { return jobId; }
            set
            { jobId = value; OnPropertyChanged(); }
        }
        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged(); }
        }
        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged(); }
        }
        public string ToDoContent
        { 
            get { return toDoContent; } 
            set { toDoContent = value; OnPropertyChanged(); } 
        }
        public string DoingContent
        {
            get { return doingContent; }
            set { doingContent = value; OnPropertyChanged(); }
        }
        public string DoneContent
        {
            get { return doneContent; }
            set { doneContent = value; OnPropertyChanged(); }
        }
        public Stopwatch Timer
        {
            get { return timer; }
            set { timer = value; OnPropertyChanged(); }
        }
        public string Reward
        {
            get { return reward; }
            set { reward = value; OnPropertyChanged();  }
        }
        public string Punishment
        {
            get { return punishment; }
            set { punishment = value; OnPropertyChanged(); }
        }
        public DateTime CreationDate
        { 
            get { return creationDate; } 
            set { creationDate = value; OnPropertyChanged(); } 
        }
        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; OnPropertyChanged(); }
        }
        public List<Job> SubJobs 
        { 
            get { return subJobs; }
            set { subJobs = value; OnPropertyChanged(); }
        }
        #region INotifyPropertyChanged Members
        //Event Handler
        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}

