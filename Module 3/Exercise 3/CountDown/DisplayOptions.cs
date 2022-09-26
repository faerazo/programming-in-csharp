//Code Example:
//Created by Farid Naisan, Jan 2012

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComboBoxEx
{
    /// <summary>
    /// Show dates in different formats.
    /// The enum is declared public and therefore it could be placed in its file.
    /// It is a type in C#.
    /// The underlying value of the first item = 0, the next = 1, and so on.
    /// but you cahange it to other values and even change the from the default
    /// int to long.
    /// </summary>
    public enum DisplayOptions
    {
        TotalDays,
        TotalMinutes,  //underlying value =0(integer)
        TotalSeconds,     //=1, can can assign other value too
        LongDateTimeFormat
    }

}
