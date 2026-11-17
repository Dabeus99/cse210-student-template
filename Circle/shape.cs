using System.Drawing;

class Shape
{
    string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public void SetColor(string color)
    {
        
    }


    public abstract double GetArea();
    
}