using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Program
    {
        public static void Main(string[] args)
        {

        }
    }

    class Ball
    {
        public string Color { get; private set; }
        public Ball(string color)
        {
            this.Color = color;
        }

    }

    class Row
    {
        public Ball[] balls = new Ball[4];

        public Row(Ball[] balls)
        {
            this.balls = balls;
        }
    }

    class Game
    {

    }

}
