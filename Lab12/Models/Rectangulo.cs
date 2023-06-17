using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab12.Models
{
    public class Rectangulo : INotifyPropertyChanged
    {
        private double baseRectangulo;
        public double BaseRectangulo
        {
            get { return baseRectangulo; }
            set
            {
                if (baseRectangulo != value)
                {
                    baseRectangulo = value;
                    OnPropertyChanged();
                }
            }
        }

        private double alturaRectangulo;
        public double AlturaRectangulo
        {
            get { return alturaRectangulo; }
            set
            {
                if (alturaRectangulo != value)
                {
                    alturaRectangulo = value;
                    OnPropertyChanged();
                }
            }
        }

        private double area;
        public double Area
        {
            get { return area; }
            set
            {
                if (area != value)
                {
                    area = value;
                    OnPropertyChanged();
                }
            }
        }

        private double perimetro;
        public double Perimetro
        {
            get { return perimetro; }
            set
            {
                if (perimetro != value)
                {
                    perimetro = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}