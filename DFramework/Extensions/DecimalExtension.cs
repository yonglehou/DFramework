﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFramework
{
    public static class DecimalExtension
    {
        public static decimal ToFixed(this decimal sourceNum, int fixedNum)
        {
            decimal sp = Convert.ToDecimal(Math.Pow(10, fixedNum));

            if (sourceNum < 0)
                return Math.Truncate(sourceNum) + Math.Ceiling((sourceNum - Math.Truncate(sourceNum)) * sp) / sp;
            else
                return Math.Truncate(sourceNum) + Math.Floor((sourceNum - Math.Truncate(sourceNum)) * sp) / sp;
        } 
    }
}
