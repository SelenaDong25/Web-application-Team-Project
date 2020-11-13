using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSD412ProjectGroup00000100.Models
{
    public class Item
    {

        private int _itemId = 0;

        private int _pollId = 0;

        private string _userId = "";

        private string _name = "";

        private string _description = "";

        [Key]
        public int ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        //[Key,ForeignKey("Poll")]
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
        public string Name

        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description

        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
