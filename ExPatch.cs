﻿using System;
using System.Collections.Generic;
using System.Text;

namespace p4gpc.inaba
{
    public class ExPatch
    {
        /// <summary>
        /// The name of the patch
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The pattern to sig scan for
        /// </summary>
        public string Pattern { get; set; }
        /// <summary>
        /// The function to add in the hook
        /// </summary>
        public string[] Function { get; set; }
        /// <summary>
        /// When to execute the function (first, after, or only)
        /// </summary>
        public string ExecutionOrder { get; set; }
        /// <summary>
        /// The offset to add to the address of the hook
        /// </summary>
        public int Offset { get; set; }
        /// <summary>
        /// If true this is a replacement instead of a code patch
        /// </summary>
        public bool IsReplacement { get; set; }

        public ExPatch(string name, string pattern, string[] function, string executionOrder, int offset, bool isReplacement)
        {
            Name = name;
            Pattern = pattern;
            Function = function;
            ExecutionOrder = executionOrder;
            Offset = offset;
            IsReplacement = isReplacement;
        }
    }
}
