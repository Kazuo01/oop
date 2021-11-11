using System;
class Rectangle
{
    protected double _width, _height;

    public Rectangle(double w, double h)
    {
        if(w <= 0 || h <=0)
            throw new ArgumentException("Invalid value.");
        _width = w;
        _height = h;
    }

    public double Area()
    {
        return _height * _width;
    }
}