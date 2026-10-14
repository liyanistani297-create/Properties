namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //עבודבה מהווב
            Rectangle rec = new Rectangle(4,5,"Rectangle"); 
            Square sq = new Square(4);
            Circle cr = new Circle(4);
            Shape[] shapes = new Shape[4];
            shapes[0] = rec;
            shapes[1] = sq;
            shapes[2] = cr;
            shapes[3] = new Rectangle(4, 5, "Rectangle");
            Console.WriteLine( sq.Area());
            foreach(Shape s in shapes )
            {
                Console.WriteLine( s.Area());
                
                //if (s is Circle )//אם זה נכון אז הוא נכנס , כלומר זה בוליאני 
                //{
                //    Console.WriteLine(((Circle)s).Radius());//קאסטינג 
                //}
                //if (s is Rectangle )//בתא 1 יצא True בגלל שעשינו הורשה שריבוע הוא מלבן כלומר שהוא גם Rectangle
                //{

                //}
                Circle c = s as Circle;// אם זה ללא נכון אז שמים null
                if ( c != null )
                {
                    Console.WriteLine (c.Radius);
                }
                
            }



        }
    }
}
