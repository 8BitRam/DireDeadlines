using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DireDeadlines
{
    internal class Project
    {
        private string daDFile;
        private string daDName;
        private bool beenSaved;
        public List<Board> Boards { get; set; } = new List<Board>();

        //Must Copy higher task hierarchy over if a subtask is transfered, and if all tasks are moved then the task is no longer displayed on the og side
        public void MoveJob()
        { 
            
        }

        public void CreateJob()
        {

        }

    }
}
