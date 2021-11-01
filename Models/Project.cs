using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class Project
    {
        public int Id { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}