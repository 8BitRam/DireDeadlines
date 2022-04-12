using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DireDeadlines.ViewModel
{
    class JobViewModel
    {
        private IList<Job> _Jobs;
        //Constructor
        public JobViewModel()
        {
            _Jobs = new List<Job>();
        }

        //public Member Interface
        public IList<Job> Jobs
        { 
            get { return _Jobs; }
            set { _Jobs = value; }
        }

        //private member updater
        private ICommand mUpdater;
        //public member update command
        public ICommand UpdateCommand;

        private class Updater : ICommand
        {
            #region ICommand Members
            public bool CanExecute(object param) { return true; }
            public event EventHandler CanExecuteChanged;
            public void Execute (object param) { }
            #endregion
        }
    }
}
