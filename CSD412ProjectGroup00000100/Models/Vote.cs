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
        private int _item_id;
        private int _poll_id;
        private int _user_id;
        private int _voter_id;
        private DateTime _vote_date_time;
        //ToDo figure out how to do a composite ForeingKey key int .net
        //[Key,ForeignKey("Item")]
        [Key]
        public int item_id
        {
            get { return _item_id; }
            set { _item_id = value; }
        }
        //[Key,ForeignKey("Poll")]
        public int poll_id
        {
            get { return _poll_id; }
            set { _poll_id = value; }
        }
        //[Key,ForeignKey("User???")] 
        public int user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        public int voter_id
        {
            get { return _voter_id; }
            set { _voter_id = value; }
        }
        public DateTime vote_date_time 
        {
            get { return _vote_date_time; }
            set { _vote_date_time = value; }
        }
    }
}
