using System.ComponentModel;

namespace MVVM
{
    class MainVM : INotifyPropertyChanged
    {
        private double _input1 = 5;
        private double _input2 = 6;
        private double _input3 = 45;
        private Parallelogram _parallelogram;

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
                    _input1 = value;
                    _parallelogram.setA(value);
                    OnPropertyChanged(nameof(Input1));
                    OnPropertyChanged(nameof(Res1));
                    OnPropertyChanged(nameof(Res2));
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
                    _input2 = value;
                    _parallelogram.setB(value);
                    OnPropertyChanged(nameof(Input2));
                    OnPropertyChanged(nameof(Res1));
                    OnPropertyChanged(nameof(Res2));
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
                    _input3 = value;
                    _parallelogram.setAngle(value);
                    OnPropertyChanged(nameof(Input3));
                    OnPropertyChanged(nameof(Res1));
                    OnPropertyChanged(nameof(Res2));
                }
            }
        }

        public double Res1 => _parallelogram.calculateHeight();
        public double Res2 => _parallelogram.calculateSquare();

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
