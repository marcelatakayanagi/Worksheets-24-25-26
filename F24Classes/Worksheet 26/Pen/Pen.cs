using System;
using System.Collections.Generic;
using System.Text;
using WorkSheets.Interfaces;

namespace WorkSheets.Worksheet_26.Pen
{
    public class Pen : IWritingUtensil
    {

        private ConsoleColor _color;
        public ConsoleColor Color { get => _color; }


        public Pen(ConsoleColor color)
        {
            _color = color;
        }


        public void Write(string color) { }

        public void Write()
        {
        }
    }

}
