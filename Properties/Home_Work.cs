using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop;

    /// <summary>
/// מחלקת בסיס מופשטת (abstract) המייצגת משקה כללי במכונה.
/// </summary>
public abstract class Drink
{
    // שדות פרטיים
    private int price;
    private int volume;

    /// <summary>
    /// שם המשקה.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// מחיר המשקה בש"ח (חייב להיות חיובי).
    /// </summary>
    public int Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
        }
    }

    /// <summary>
    /// נפח המשקה במיליליטרים (חייב להיות חיובי).
    /// </summary>
    public int Volume
    {
        get { return volume; }
        set
        {
            if (value >= 50 && value <= 1500)
                volume = value;
        }
    }

    /// <summary>
    /// פעולה בונה (Constructor) למחלקה Drink.
    /// </summary>
    /// <param name="name">שם המשקה</param>
    /// <param name="price">מחיר בסיסי בש"ח</param>
    /// <param name="volume">נפח במיליליטר</param>
    public Drink(string name, int price, int volume)
    {
        this.Name = name;
        this.Price = price;
        this.Volume = volume;
    }
}


/// <summary>
/// מחלקה מופשטת המייצגת משקה חם, היורשת ממחלקת Drink.
/// </summary>
public abstract class HotDrink : Drink
{
    private double temperature;

    /// <summary>
    /// טמפרטורת המשקה במעלות צלזיוס (בין 30 ל-95).
    /// </summary>
    public double Temperature
    {
        get { return temperature; }
        set
        {
            if (value >= 30 && value <= 95)
                temperature = value;
        }
    }

    /// <summary>
    /// פעולה בונה למשקה חם.
    /// </summary>
    /// <param name="name">שם המשקה</param>
    /// <param name="price">מחיר המשקה</param>
    /// <param name="volume">נפח במיליליטר</param>
    /// <param name="temperature">טמפרטורת המשקה</param>
    public HotDrink(string name, int price, int volume, double temperature)
        : base(name, price, volume)
    {
        Temperature = temperature;
    }
    public  virtual double CalculatePrice ()//הפעולה הזו הופכת להיות ברירת מחדל לכל מי שיורש ממנה. כלומר אם לא משנים את המחיר או את הטיפ אז הוא בא לפה.
    {
        return Price *1.1;
    }

    public class Espresso : HotDrink
    {
        private int numShots;

        public int NumShots
        {
            get { return numShots; }
            set
            {
                if (value > 0)
                    numShots = value;
            }
        }

        public Espresso(string name, int price, int volume,
                        double temperature, int numShots)
            : base(name, price, volume, temperature)
        {
            NumShots = numShots;
        }

        public class Affogato : Espresso
        {
            private int numIceCreamBalls;

            public int NumIceCreamBalls
            {
                get { return numIceCreamBalls; }
                set
                {
                    if (value >= 1)
                        numIceCreamBalls = value;
                }
            }

            public Affogato(string name, int price, int volume,
                            double temperature, int numIceCreamBalls)
                : base(name, price, volume, temperature, 1)
            {
                NumIceCreamBalls = numIceCreamBalls;
            }

            public override double CalculatePrice()
            {
                return base.CalculatePrice () + NumIceCreamBalls * 5;
            }
        }

    }

    internal class Home_Work
    {
    }
}

