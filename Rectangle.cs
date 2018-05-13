public class Rectangle : Shape
{
  private double height, width;
  public Rectangle(double height, double width) {
    this.height = height;
    this.width = width;
  }
  public override double calculateArea()
  {
    return height * width;
  }

  public override double calculateCircumference()
  {
    return height*2+width*2;
  }
}