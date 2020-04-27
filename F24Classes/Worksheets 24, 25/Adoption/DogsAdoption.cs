using System;
using System.Collections.Generic;
using System.Text;

namespace WorkSheets.Pets
{
    public class DogsAdoption
    {
        private string _name;
        private int _age;
        private string _color;
        private bool _isAvailable;
        private bool _sociability;
        private bool _neutered;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value)) this._name = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
        }
        public string Breed { get; set; }
        public string Color
        {
            get
            {
                return _color;
            }
        }
        public bool IsAvailable
        {
            get
            {
                return _isAvailable;
            }
        }
        public bool Sociability
        {
            get
            {
                return _sociability;
            }
        }
        public bool Neutered
        {
            get
            {
                return _neutered;
            }
        }


        public DogsAdoption(string name, int age, string breed, string color)
        {
            _name = name;
            _age = age;
            Breed = breed;
            _color = color;
            _isAvailable = false;
            _sociability = true;
            _neutered = false;
        }

        public void FriendlyDog()
        {
            _sociability = true;
        }
        public void BadAssDog()
        {
            _sociability = false;
        }

        public void Neuter()
        {
            _neutered = true;
        }

        public void makeAvailable()
        {
            _isAvailable = true;
        }





    }
}
