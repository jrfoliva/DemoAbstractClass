using System;
using System.Collections.Generic;
using DemoAbstractClass.Entities.Enums;

namespace DemoAbstractClass.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); 
        
    }
}
