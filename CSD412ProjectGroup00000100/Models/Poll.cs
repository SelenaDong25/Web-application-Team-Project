using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSD412ProjectGroup00000100.Models
{
    public class Poll
    {
       private int _pollId = 0;
       private int _userId = 0;
       private String _name = "";
       private String _description = "";
       private Boolean _State = false;
       [Key]
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
            get { return _State; }
            set { _State = value; }
        }
    }
}
