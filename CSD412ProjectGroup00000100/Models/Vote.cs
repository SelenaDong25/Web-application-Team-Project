using System;
using System.ComponentModel.DataAnnotations;

namespace CSD412ProjectGroup00000100.Models
{
    public class Vote
    {
        private int _ItemId = 0;
        private int _PollId = 0;
        private int _UserId = 0;
        private int _VoterId = 0;
        private DateTime _VoteDateTime = DateTime.MinValue;
        //ToDo figure out how to do a composite ForeingKey key int .net
        //[Key,ForeignKey("Items")]
        [Key]
        public int itemId
        {
            get { return _ItemId; }
            set { _ItemId = value; }
        }
        //[Key,ForeignKey("Polls")]
        public int pollId
        {
            get { return _PollId; }
            set { _PollId = value; }
        }
        //[Key,ForeignKey("User???")] 
        public int userId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public int voterId
        {
            get { return _VoterId; }
            set { _VoterId = value; }
        }
        public DateTime voteDateTime
        {
            get { return _VoteDateTime; }
            set { _VoteDateTime = value; }
        }
    }
}
