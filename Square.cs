public class Square : Rectangle
{
  public Square(double side) : base(side, side)
  {    
  }

  //om inte denna funnits här så ahde den skrivit ut "I am default shape" från den virtuella metoden i Shapeclassen
  public override string getInfo() {
    return "I am a Square!";
  }
}