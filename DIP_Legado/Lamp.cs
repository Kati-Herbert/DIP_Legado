using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Legado
{
    public class Lamp: IDevices
    {
        private State State { get; set; }

        public Lamp()
        {
            State = State.Off;
        }

        public void Ligar()
        {
            if (State == State.Off)
            {
                State = State.On;
                Console.WriteLine("Luz Ligada");
            }
            else
            {
                Console.WriteLine("A luz já está ligada.");
            }
        }

        public void Desligar()
        {
            if (State == State.On)
            {
                State = State.Off;
                Console.WriteLine("Luz Desligada");
            }
            else
            {
                Console.WriteLine("A luz já está desligada.");
            }
        }

        public State GetState()
        {
            return State;
        }

    }
}
