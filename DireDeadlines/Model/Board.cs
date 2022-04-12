using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region INotifyPropertyChanged Namespaces
using System.ComponentModel;
using System.Runtime.CompilerServices;
#endregion

namespace DireDeadlines
{
    internal class Board : INotifyPropertyChanged
    {
        private string name;
        public List<Job> Jobs { get; set; } = new List<Job>();



        public string Name { get { return name; } set { name = value; } }

        public void DeleteJob(int id) 
        {
            //Notify subjobs to check for id and delete subjobs
            Jobs.Remove(GetJobById(id));
        }

        public void AddJob()
        {
            //Utilize templates to instantiate new job 
            Jobs.Add(new Job());
        }

        public Job GetJobById(int jobId)
        {
            //propgate to find the specific id
            return Jobs.Find(x => x.JobId == jobId);
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
