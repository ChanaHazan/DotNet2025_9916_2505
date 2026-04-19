using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlImplemention;

namespace BlApi
{
    public static class Factory
    {
        public static IBl Get()
        {
            Bl instance = new Bl();
            return instance;
        }
    }
}
