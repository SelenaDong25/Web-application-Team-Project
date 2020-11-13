using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CSD412ProjectGroup00000100.Models
{
    public class Vote

    {
        private int _itemId = 0;

        private int _pollId = 0;

        private string _userId = "";
        public virtual Item Item { get; set; }

        private string _voterId = "";
       public virtual ApplicationUser Voter { get; set; }

        private DateTime _voteDateTime = DateTime.MinValue;
   
        [Key]
        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
    
        public int PollId
        {
            get { return _pollId; }
            set { _pollId = value; }
        }
                public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string VoterId
        {
            get { return _voterId; }
            set { _voterId = value; }
        }
        public DateTime VoteDateTime
        {
            get { return _voteDateTime; }
            set { _voteDateTime = value; }

        }
    }
}
