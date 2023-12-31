﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetApp.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public int GroupId { get; set; }

        public virtual Group Group { get; set; } 
    }
}
