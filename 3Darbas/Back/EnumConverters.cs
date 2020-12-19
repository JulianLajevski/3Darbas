using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Darbas
{
    static class EnumConverters
    {
        public static int getUserTypeID(UserType userType)
        {
            return (int) userType;
        }
        public static UserType getUserType(int id)
        {
            return (UserType) id;
        }
    }
}
