using System;
using System.ComponentModel.DataAnnotations;

namespace CSD412ProjectGroup00000100.Models
{
    public class Vote
    {
        private int _itemId = 0;

        private int _pollId = 0;

        private int _userId = 0;

        private int _voterId = 0;

        private DateTime _voteDateTime = DateTime.MinValue;

        //ToDo figure out how to do a composite ForeingKey key int .net
        //[Key,ForeignKey("Items")]
        [Key]
        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        //[Key,ForeignKey("Polls")]
        public int PollId
        {
            get { return _pollId; }
            set { _pollId = value; }
        }
        //[Key,ForeignKey("User???")] 
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public int VoterId
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
