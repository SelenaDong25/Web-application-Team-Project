﻿using System;
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
        private int _userId = 0;
        private int _voterId = 0;
        private DateTime _voteDateTime = DateTime.Now;
        //ToDo figure out how to do a composite ForeingKey key int .net
        //[Key,ForeignKey("Items")]
        [Key]
        public int itemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        //[Key,ForeignKey("Polls")]
        public int pollId
        {
            get { return _pollId; }
            set { _pollId = value; }
        }
        //[Key,ForeignKey("User???")] 
        public int userId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public int voter_id
        {
            get { return _voterId; }
            set { _voterId = value; }
        }
        public DateTime voteDateTime 
        {
            get { return _voteDateTime; }
            set { _voteDateTime = value; }
        }
    }
}
