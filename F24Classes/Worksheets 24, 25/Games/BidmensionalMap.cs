using System;
using System.Collections.Generic;
using System.Text;

namespace WorkSheets.Games
{
    //i decided to use struct because the data is small and since I assume it would be istanciated many times it would make the aplication faster 
    struct BidmensionalMap
    {
        private double _x;
        private double _y;
        private string _indicacao;

        public double x
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public double y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        public string indicacao
        {
            get
            {
                return _indicacao;
            }
            set
            {
                _indicacao = value;
            }
        }
    }
}

   


