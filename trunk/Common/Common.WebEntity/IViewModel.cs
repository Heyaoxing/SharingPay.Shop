﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.WebEntity
{
    public abstract class IViewModel
    {
        /// <summary>
        /// 总条数
        /// </summary>
        public int total { get; set; }
    }
}
