using System;
using System.Collections.Generic;
using System.Text;

namespace WorkSheets.Games
{
    struct PianoVirtual
    {
        private int _position;
        private string _color;
        private string _note;

        public int position
        {
            get
            {
                return _position;
            }
        }

        public string color
        {
            get
            {
                return _color;
            }
        }

        public string note
        {
            get
            {
                return _note;
            }
        }
    }

}
