using System;

namespace enumStruct
{
    class Program
    {
        //Bunch of loosely related stuff in a struct.
        public struct Monster
        {
            public string name;
            public int health;
            public int damage;
            public Element element;
            //Example type comparison
            public static bool compareType(Element e1, Element e2)
            {
                if (e1 == Element.Fire)
                {
                    if (e2 == Element.Water)
                    {
                        return "Fire is weak against water.";
                    }

                    //etc, etc...
                }

                //etc, etc...


                return null;
            }

            override
             public string ToString()
            {
                return string.Format("{0}s have {1} health, do {2} damage and have {3} as their element.", name, health, damage, element);
            }
        }
        //Rock, Paper, Scissors-esque elements.
        public enum Element
        {
            Fire, Water, Nature
        }

        static void Main(string[] args)
        {
            Monster fireDragon = new Monster();
            fireDragon.name = "Fire Dragon";
            fireDragon.element = Element.Fire;

            Monster kraken = new Monster();
            kraken.name = "Kraken";
            kraken.element = Element.Water;

            Console.WriteLine(fireDragon);
            Console.WriteLine("The Dragon and Kraken fight.");
            Console.WriteLine(Monster.compareType(fireDragon.element, kraken.element));
        }
    }
}
