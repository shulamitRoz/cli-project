using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Enum
{
    public enum Seasons :byte
    {
        winter=1,
        Autumn,
        Spring,
        summer,

    }
    [Flags]
    public enum WeekDay 
    {
        sunday=1,
        monday=2,
        Tuesday=4 , 
        Wednesday=8,
        Thursday=16 ,
        Friday=32 ,

    }
}
