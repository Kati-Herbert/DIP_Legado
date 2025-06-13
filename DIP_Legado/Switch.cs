using DIP_Legado;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Legado
{
    public class Switch
    {
        private readonly IDevices device;

        public Switch(IDevices device)
        {
            this.device = device;
        }

        public void Ligar()
        {
            device.Ligar();
        }

        public void Desligar()
        {
            device.Desligar();
        }

    }
}