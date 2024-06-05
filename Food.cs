using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Food
    {
        private Point _Food;
        private Random Random;

        public Food()
        {
            Random = new Random();
            _Food = new Point(Random.Next(1, FormParams.Width / 30) * 30, Random.Next(1, FormParams.Height / 30) * 30);
        }

        public Point FoodCoords { get { return _Food; } }
    }
}