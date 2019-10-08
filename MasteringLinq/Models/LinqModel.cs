using System;
using System.Collections.Generic;
using System.Text;

namespace MasteringLinq.Models
{
    public class LinqModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
