


abstract class Shape
{
    // Abstract method: To be implemented by derived classes
    public abstract double CalculateArea();

    // Concrete method
    public void DisplayArea()
    {
        Console.WriteLine("Area: " + CalculateArea());
    }
}