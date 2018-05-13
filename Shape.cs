public abstract class Shape
{
  public abstract double calculateArea();

  public abstract double calculateCircumference();

  public virtual string getInfo() {
    return "I am the default Shape";
  }

}