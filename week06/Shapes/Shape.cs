using System;

namespace Shapes
{
    public abstract class Shape
    {
        protected string _color;
        public Shape(string color)
        {
            _color = color;
        }
        public string GetColor() => _color;

        public string SetColor(string color) => _color = color;

        public abstract double GetArea();
    }
}