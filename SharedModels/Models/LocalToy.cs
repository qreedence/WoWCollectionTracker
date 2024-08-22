﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models
{
    public class LocalToy
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public string Icon { get; set; }
        public string Patch { get; set; }
        public string SubCategory { get; set; }
        public string? SubSubCategory { get; set; }
        public bool Collected { get; set; }
        public bool Tracked { get; set; }
        public bool Show { get; set; }
        public int DisplayOrder { get; set; }
        public bool Unobtainable { get; set; }
    }
}