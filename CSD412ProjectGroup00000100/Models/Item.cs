using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSD412ProjectGroup00000100.Models
{
    public class Item
    {
        private int _item_id;
        private int _poll_id;
        private int _user_id;
        private string _name;
        private String _description;
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
        public int user_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        public String name
        {
            get { return _name; }
            set { _name = value; }
        }
        public String description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
