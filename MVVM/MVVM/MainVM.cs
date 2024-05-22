using System.ComponentModel;

namespace MVVM
{
    class MainVM : INotifyPropertyChanged
    {
        private double _input1 = 5;
        private double _input2 = 6;
        private double _input3 = 45;
        private Parallelogram _parallelogram;
        private string _errorMessage;

        public MainVM()
        {
            _parallelogram = new Parallelogram(_input1, _input2, _input3);
        }

        public double Input1
        {
            get { return _input1; }
            set
            {
                if (_input1 != value)
                {
                    if (value <= 0)
                    {
                        ErrorMessage = "Side a must be greater than zero.";
                        return;
                    }
                    _input1 = value;
                    _parallelogram.SetA(value);
                    OnPropertyChanged(nameof(Input1));
                    UpdateResults();
                }
            }
        }

        public double Input2
        {
            get { return _input2; }
            set
            {
                if (_input2 != value)
                {
                    if (value <= 0)
                    {
                        ErrorMessage = "Side b must be greater than zero.";
                        return;
                    }
                    _input2 = value;
                    _parallelogram.SetB(value);
                    OnPropertyChanged(nameof(Input2));
                    UpdateResults();
                }
            }
        }

        public double Input3
        {
            get { return _input3; }
            set
            {
                if (_input3 != value)
                {
                    if (value <= 0 || value >= 180)
                    {
                        ErrorMessage = "Angle must be between 0 and 180 degrees.";
                        return;
                    }
                    _input3 = value;
                    _parallelogram.SetAngle(value);
                    OnPropertyChanged(nameof(Input3));
                    UpdateResults();
                }
            }
        }

        public double Res1 => _parallelogram.calculateHeight();
        public double Res2 => _parallelogram.calculateSquare();

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                if (_errorMessage != value)
                {
                    _errorMessage = value;
                    OnPropertyChanged(nameof(ErrorMessage));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void UpdateResults()
        {
            OnPropertyChanged(nameof(Res1));
            OnPropertyChanged(nameof(Res2));
            ErrorMessage = string.Empty;  // Clear error message on successful update
        }
    }

}
