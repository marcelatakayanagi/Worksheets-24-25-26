using System;
using System.Collections.Generic;
using System.Text;
using WorkSheets.Interfaces;


namespace WorkSheets.Worksheet_26.Pencil
{
    public class Pencil : IErasable, IWritingUtensil
    {
        private ConsoleColor _color;
        public ConsoleColor Color { get => _color; }

        public Pencil()
        {
            _color = ConsoleColor.White;
        }

        public void Erase()
        {

        }

        public void Write()
        {

        }
    }

}
