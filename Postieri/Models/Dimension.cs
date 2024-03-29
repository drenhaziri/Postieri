﻿using System.ComponentModel.DataAnnotations;

namespace Postieri.Models
{
    public class Dimension
    {
        [Key]
        public Guid Id { get; set; }
        public string name { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public double length { get; set; }
        public bool inUse   { get; set; }
    }
}
