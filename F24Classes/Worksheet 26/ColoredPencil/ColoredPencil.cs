using System;
using System.Collections.Generic;
using System.Text;
using WorkSheets.Interfaces;

namespace WorkSheets.Worksheet_26.ColoredPencil
{
    public class ColoredPencil : IWritingUtensil
    {
        private ConsoleColor _color;
        public ConsoleColor Color { get => _color; }

        public ColoredPencil(ConsoleColor color)
        {
            _color = color;
        }

        public void Erase()
        {
            
        }

        public void Write()
        {
           
        }
    }
}
