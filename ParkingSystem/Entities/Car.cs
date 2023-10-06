namespace ParkingSystem.Entities
{
    class Car
    {
        private string? _model { get; set; }
        private string? _carSign;

        public Car(string Model, string CarSign) 
        { 
        
            _model = Model;
            _carSign = CarSign;
            
        }

        
        public string? CarSign
        {
            get { return _carSign; }
            set { _carSign = value; }
        }

        public string? Model 
        { 
            get { return _model; } 
            set { _model = value; } 
        }


    }
}
