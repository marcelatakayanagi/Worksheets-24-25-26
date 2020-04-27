using System;
using System.Collections.Generic;
using System.Text;

namespace WorkSheets.Interfaces
{
    public interface IWritingUtensil
    {

        ConsoleColor Color { get; }

        public void Write();

    }
}
