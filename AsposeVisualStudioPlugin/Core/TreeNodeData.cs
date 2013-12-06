﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsposeVisualStudioPlugin.Core
{
    public class TreeNodeData
    {
        string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        Example _example;

        public Example Example
        {
            get { return _example; }
            set { _example = value; }
        }
    }
}
