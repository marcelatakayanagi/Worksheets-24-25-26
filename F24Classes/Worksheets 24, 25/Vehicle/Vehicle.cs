using System;

namespace WorkSheets
{
    /// <summary>
    /// Represents a vehicle 
    /// </summary>
    public class Vehicle : IVehicle
    {
        /// <summary>
        /// Represents vehicle´s brand
        /// </summary>
        private string _brand;
        public string Brand {get; set; }

        /// <summary>
        /// Represents vehicle´s model
        /// </summary>
        private string _model;
        public string Model {get; set; }

        /// <summary>
        /// Represents vehicle lincence plate year
        /// </summary>
        private int _licensePlateYear;
        public int LincensePlateYear {get; set; }
        
        /// <summary>
        /// Represents if the vehicle is on or off
        /// </summary>
        private bool _isOn;
        public bool IsOn {get; set; }
       
        /// <summary>
        /// Represents vehicle´s maximum speed
        /// </summary>
        private int _maxSpeed;
        public int MaxSpeed {get; set; }
        
        /// <summary>
        /// Represents vehicle´s current speed
        /// </summary>
        private int _currentSpped;
        public int CurrentSpeed {get; set; }
       
        /// <summary>
        /// Represents vehicle´s wheel direction
        /// </summary>
        private string _wheelDirection;
        public string WheelDirection {get; set; }
        
        private char _gear;
        public char Gear {get; set; }

        /// <summary>
        /// Constructs a vehicle using the following params
        /// </summary>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="licensePlate"></param>
        /// <param name="maxSpeed"></param>
        public Vehicle(string brand, string model, int licensePlateYear, int maxSpeed)
        {
            _brand = brand;
            _model = model;
            _licensePlateYear = licensePlateYear;
            _isOn = false;
            _maxSpeed = maxSpeed;
            _currentSpped = 0;
            _wheelDirection = "center";
            _gear = 'N';
        }
        /// <summary>
        /// Turn the vehicle on
        /// </summary>
        public void Start()
        {
            _isOn = true; 
        }

        /// <summary>
        /// Turn the vehicle off
        /// </summary>
        public void Stop()
        {
            _isOn = false;
        }

        /// <summary>
        /// Increase vehicle's current speed
        /// </summary>
        /// <param name="speed"></param>
        public void Accelerate(int speed)
        {
            var newSpeed = _currentSpped + speed;
            if (newSpeed < _maxSpeed)
                _currentSpped = newSpeed;
            else
                _currentSpped = _maxSpeed;
        }

        /// <summary>
        /// Decrement vehicle´s current speed
        /// </summary>
        /// <param name="speedDown"></param>
        public void Brake(int speedDown)
        {
            var brakeSpeed = _currentSpped - speedDown;
            if (brakeSpeed > 0)
                _currentSpped = brakeSpeed;
            else
                _currentSpped = 0;
        }
        /// <summary>
        /// Change vehicle´s wheel direction
        /// </summary>
        /// <param name="direction"></param>
        public void TurnWheel(string direction)
        {
            if (direction == "center" || direction == "right" || direction == "left")
                this._wheelDirection = direction;
            else
                Console.WriteLine($"The wheel cannot turn to this direction: {direction}");
        }
        /// <summary>
        /// Change vehicle´s gear
        /// </summary>
        /// <param name="gear"></param>
        public void ChangeGear(char gear)
        {
            if (gear == 'R' || gear == 'N' || gear == '1' || gear == '2' || gear == '3' || gear == '4' || gear == '5')
                this._gear = gear;
            else
                Console.Write($"This gear does not exist. Therefore it sets on N. ");
        }
    }


}
