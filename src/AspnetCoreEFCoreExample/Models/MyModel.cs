﻿using System.ComponentModel.DataAnnotations;

namespace AspnetCoreEFCoreExample.Models
{
    public class MyModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MySecondModel SecondModel { get; set; }
    }
}
