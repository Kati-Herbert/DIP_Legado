﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Legado
{
    public interface IDevices
    {
        void Ligar();
        void Desligar();
        State GetState();
    }
}
