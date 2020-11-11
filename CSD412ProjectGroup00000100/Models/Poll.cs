using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSD412ProjectGroup00000100.Models
{
    public class Poll
    {
       private int _poll_id;
       private int _user_id;
       private String _name;
       private String _description;
       private Boolean _state;
       [Key]
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
        public Boolean state
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
