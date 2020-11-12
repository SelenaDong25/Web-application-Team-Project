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
       public int PollId
       {
            get { return _PollId; }
            set { _PollId = value; }
       }
        //[Key,ForeignKey("User???")] 
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        public Boolean State
        {
            get { return _State; }
            set { _State = value; }
        }
    }
}
