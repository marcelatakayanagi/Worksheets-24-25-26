using System;
using System.Collections.Generic;
using System.Text;

namespace WorkSheets
{
    interface IVehicle
    {
        public void Start();
        public void Stop();
        public void ChangeGear(char gear);
        public void Brake(int speedDown);
        public void Accelerate(int speed);
        public void TurnWheel(string direction);

    }
}
