using System;
namespace Day_2{
    public class Rectangle{
        public Rectangle(Point tleft, Point botRight){
            TopLeft = tleft;
            BottomRight = botRight;
        }
        
        public Point TopLeft {get; set;}
        public Point BottomRight {get; set;}
    }
}
