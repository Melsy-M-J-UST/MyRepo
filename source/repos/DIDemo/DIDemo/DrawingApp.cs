using System;
using System.Collections.Generic;
using System.Text;

namespace DIDemo
{
    public class DrawingApp
    {
        //Circle circle = new Circle();
        //Triangle triangle = new Triangle();
        private Shape shape;
        public DrawingApp(Shape shape)//constructor injection
        {
            this.shape = shape;
        }
        public void DrawShapes()//method injection
        {
            //circle.Draw();
            //triangle.Draw();
            shape.Draw();
        }
        
    }
}
