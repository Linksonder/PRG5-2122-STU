using System;
using System.Collections.Generic;
using System.Text;

namespace WieIsDeMol.domain
{
    public static class MyExtensions
    {
        public static Gender toGender(this String gender)
        {
            return (Gender)Enum.Parse(typeof(Gender), gender);
        }
    }
}
