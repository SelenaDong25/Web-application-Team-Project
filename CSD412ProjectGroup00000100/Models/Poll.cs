using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CSD412ProjectGroup00000100.Models
{
    public class Poll
    {
       private int _PollId = 0;
       private int _UserId = 0;
       private String _Name = "";
       private String _Description = "";
       private Boolean _State = false;
       [Key]
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
        public String name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public String description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public Boolean state
        {
            get { return _State; }
            set { _State = value; }
        }
    }
}
