using Lab12.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab12.ViewModels
{
    public class RectanguloViewModel : INotifyPropertyChanged
    {
        private Rectangulo rectangulo;

        public double BaseRectangulo
        {
            get { return rectangulo.BaseRectangulo; }
            set
            {
                if (rectangulo.BaseRectangulo != value)
                {
                    rectangulo.BaseRectangulo = value;
                    OnPropertyChanged();
                }
            }
        }

        public double AlturaRectangulo
        {
            get { return rectangulo.AlturaRectangulo; }
            set
            {
                if (rectangulo.AlturaRectangulo != value)
                {
                    rectangulo.AlturaRectangulo = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Area
        {
            get { return rectangulo.Area; }
            set
            {
                if (rectangulo.Area != value)
                {
                    rectangulo.Area = value;
                    OnPropertyChanged();
                }
            }
        }

        public double Perimetro
        {
            get { return rectangulo.Perimetro; }
            set
            {
                if (rectangulo.Perimetro != value)
                {
                    rectangulo.Perimetro = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CalcularAreaCommand { get; private set; }
        public ICommand CalcularPerimetroCommand { get; private set; }

        public RectanguloViewModel()
        {
            rectangulo = new Rectangulo();
            CalcularAreaCommand = new Command(CalcularArea);
            CalcularPerimetroCommand = new Command(CalcularPerimetro);
        }

        private void CalcularArea()
        {
            Area = BaseRectangulo * AlturaRectangulo;
        }

        private void CalcularPerimetro()
        {
            Perimetro = 2 * (BaseRectangulo + AlturaRectangulo);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}