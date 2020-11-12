using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSD412ProjectGroup00000100.Models
{
    public class Item
    {
        private int _ItemId = 0;
        private int _PollId = 0;
        private int _UserId = 0;
        private string _Name = "";
        private string _Description = "";
        [Key]
        public int ItemId
        {
            get { return _ItemId; }
            set { _ItemId = value; }
        }
        //[Key,ForeignKey("Poll")]
        public int PollId
        {
            get { return _PollId; }
            set { _PollId = value; }
        }
        public int userId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
    }
}
