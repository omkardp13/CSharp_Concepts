abstract class Shape
{
  public abstract double Area();
}

//concreate implementation of shape for rectangle

class Reactangle:Shape
{
   public double width {get;set;}
   public double height {get;set;}

   public override double Area()
  {
      return width*height;
  }
}

//concreate implementation of shape for circle

class circle:shape
{
   public double radius {get;set;}
   

   public override double Area()
  {
      return Math.pi*radius*radius;
  }
}
