using System;
using System.Collections.Generic;
using System.Text;

namespace WorkSheets
{
        /// <summary>
        /// Represents a boat
        /// </summary>
        public class Boat : IVehicle
        {   /// <summary>
            /// Represents boat´s brand
            /// </summary>
            private string _brand;
            public string Brand { private get; set; }
            /// <summary>
            /// Represents boat´s  model
            /// </summary>
            private string _model;
            public string Model { private get; set; }
            /// <summary>
            /// Represents boat year
            /// </summary>
            private int _year;
            public int Year { private get; set; }
            /// <summary>
            /// Represents if the boat is on or off
            /// </summary>
            private bool _isOn;
         public bool IsOn { private get; set; }

            /// <summary>
            /// Represents boat´s  maximum speed
            /// </summary>
            private int _maxSpeed;
            public int MaxSpeed { private get; set; }

            /// <summary>
            /// Represents boat´s current speed
            /// </summary>
            private int _currentSpeed;
            public int CurrentSpeed { private get; set; }
           
            /// <summary>
            /// Represents boat´s  wheel direction
            /// </summary>
            private string _wheelDirection;
            public string WheelDirection { private get; set; }
           
            private char _gearPosition;
            public char Gear { private get; set; }
           
            /// <summary>
            /// Constructs the boat
            /// </summary>
            /// <param name="brand"></param>
            /// <param name="model"></param>
            /// <param name="year"></param>
            /// <param name="maxSpeed"></param>
            public Boat(string brand, string model, int year, int maxSpeed)
            {
                _brand = brand;
                _model = model;
                _year = year;
                _maxSpeed = maxSpeed;
                _isOn = false;
                _currentSpeed = 0;
                _wheelDirection = "center";
                _gearPosition = 'N';
            }
            /// <summary>
            /// Turn the boat on
            /// </summary>
            public void Start()
            {
                _isOn = true;
            }
            /// <summary>
            /// Turn the boat off
            /// </summary>
            public void Stop()
            {
                _isOn = false;
            }
            /// <summary>
            /// Increase boat's current speed
            /// </summary>
            /// <param name="speed"></param>
            public void Accelerate(int speed)
            {
                var newSpeed = _currentSpeed + speed;
                if (newSpeed < _maxSpeed)
                    _currentSpeed = newSpeed;
                else
                    _currentSpeed = MaxSpeed;
            }
            /// <summary>
            /// Drecrease boat´s current speed
            /// </summary>
            /// <param name="speedDown"></param>
            public void Brake(int speedDown)
            {
                var brakeSpeed = _currentSpeed - speedDown;
                if (brakeSpeed > 0)
                    _currentSpeed = brakeSpeed;
                else
                    _currentSpeed = 0;
            }
            /// <summary>
            /// Changes boat´s gear
            /// </summary>
            /// <param name="gear"></param>
            public void ChangeGear(char gear)
            {
                if (gear != 'N' && gear != 'R' && gear != '1' && gear != '2' && gear != '3' && gear != '4' && gear != '5')
                    Console.Write($"This gear does not exist. Therefore should be on N. ");
                else
                    this._gearPosition = gear;
            }
            /// <summary>
            /// Turn boat wheel direction
            /// </summary>
            /// <param name="direction"></param>
            public void TurnWheel(string direction)
            {
                if (direction == "center" || direction == "right" || direction == "left")
                    this._wheelDirection = direction;
                else
                    Console.WriteLine($"It is not possible to turn to {direction}");

            }
        }
 }

