using System;
using System.Runtime.CompilerServices;
using Prism.Mvvm;

namespace PointOfSale.Models
{
    public class LoginModel:BindableBase
    {
        public event EventHandler<string> PinTyped;

        private int? _firstNumber;
        public int? FirstNumber
        {
            get => _firstNumber;
            set
            {
                SetProperty(ref _firstNumber, value);
                RaisePropertyChanged(nameof(FirstNumberString));
            }
        }
        public string FirstNumberString => GetStringOrNull();

        private int? _secondNumber;
        public int? SecondNumber
        {
            get => _secondNumber;
            set
            {
                SetProperty(ref _secondNumber, value);
                RaisePropertyChanged(nameof(SecondNumberString));
            }
        }
        public string SecondNumberString => GetStringOrNull();


        private int? _thirdNumber;
        public int? ThirdNumber
        {
            get => _thirdNumber;
            set
            {
                SetProperty(ref _thirdNumber, value);
                RaisePropertyChanged(nameof(ThirdNumberString));
            }
        }
        public string ThirdNumberString => GetStringOrNull();

        private int? _fourthNumber;
        public int? FourthNumber
        {
            get => _fourthNumber;
            set
            {
                SetProperty(ref _fourthNumber, value);
                RaisePropertyChanged(nameof(FourthNumberString));
            }
        }
        public string FourthNumberString => GetStringOrNull();

        private string GetStringOrNull([CallerMemberName] string propertyName=null)
        {
            propertyName = propertyName.Replace("String", "");
            var property = GetType().GetProperty(propertyName);
            if (property.GetValue(this) is int value) return "*";

            return String.Empty;
        }

        public void Clear()
        {
            FirstNumber = null;
            SecondNumber = null;
            ThirdNumber = null;
            FourthNumber = null;
        }

        public void AddNextNumber(int number)
        {
            if (string.IsNullOrWhiteSpace(FirstNumberString))
            {
                FirstNumber = number;
                return;
            }

            if (string.IsNullOrWhiteSpace(SecondNumberString))
            {
                SecondNumber = number;
                return;
            }

            if (string.IsNullOrWhiteSpace(ThirdNumberString))
            {
                ThirdNumber = number;
                return;
            }

            
             FourthNumber = number;
             PinTyped?.Invoke(this, ToString());
        }

        public override string ToString()
        {
            return $"{FirstNumber}{SecondNumber}{ThirdNumber}{FourthNumber}";
        }
    }
}