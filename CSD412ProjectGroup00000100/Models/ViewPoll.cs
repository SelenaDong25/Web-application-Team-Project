using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSD412ProjectGroup00000100.Models
{
    public class ViewPoll
    {
        private Boolean _showResult = false;
        public IEnumerable<Item> Items { get; set; }
        public Poll CurrentPoll { get; set; }

        // stores all the results of the poll
        public List<object> IData { get; set; }
        public Boolean ShowResult
        {
            get { return _showResult; }
            set { _showResult = value; }
        }
    }
}
