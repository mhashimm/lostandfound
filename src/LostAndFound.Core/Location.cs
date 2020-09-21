﻿using LostAndFound.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LostAndFound.Core
{
    public class Location: BaseEntity
    {
        public string Name { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }


    }
}
