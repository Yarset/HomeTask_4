namespace Weapon
{
    public interface weapon
    {
        
        public string shot {get; }
        public void ob() { }
       
    }
   
    public class waterGun : weapon 
    {
       int bullets=5;
        string sound = "Пшик-Пшик";
        public string shot
        {
            get {
                if (bullets > 0)
                {
                    this.bullets--;
                    return sound;
                }
                else return "Обойма пуста";
            }
        }
        public void ob()
        {
            Console.WriteLine($"В обойме {this.bullets} пуль");
        }
       
    }
    public class Gun : weapon
    {
        int bullets = 7;
        string sound = "Пах-Пах";
        public string shot
        {
            get
            {
                if (bullets > 0)
                {
                    this.bullets--;
                    return sound;
                }
                else return "Обойма пуста";
            }
        }
        public void ob()
        {
            Console.WriteLine($"В обойме {this.bullets} пуль");
        }
    }
    public class Automat:weapon
    {
        int bullets = 10;
        string sound = "Тра-та-та";
        public string shot
        {
            get
            {
                if (bullets > 0)
                {
                    this.bullets--;
                    return sound;
                }
                else return "Обойма пуста";
            }
        }
        public void ob()
        {
            Console.WriteLine($"В обойме {this.bullets} пуль");
        }
       
    }
    public class Rogatka : weapon 
    {
        int bullets = 3;
        string sound = "Вшух";
        public string shot
        {
            get
            {
                if (bullets > 0)
                {
                    this.bullets--;
                    return sound;
                }
                else return "Обойма пуста";
            }
        }
        public void ob()
        {
            Console.WriteLine($"В обойме {this.bullets} пуль");
        }
    }
    public class RPG:weapon
    {
        int bullets = 1;
        string sound = "Бабах";
        public string shot
        {
            get
            {
                if (bullets > 0)
                {
                    this.bullets--;
                    return sound;
                }
                else return "Обойма пуста";
            }
        }
        public void ob()
        {
            Console.WriteLine($"В обойме {this.bullets} пуль");
        }
    }
}
