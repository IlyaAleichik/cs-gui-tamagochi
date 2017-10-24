using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi_IlyaProject
{

    class Bird : Person
    {
        public Bird()
        {
            
            step_eat = 2;
            step_health = 1;
            step_water = 3;
            interval = 50;
            Eat = Water = Health = 108;

        }
    }
    class Kitten : Person
    {

        public Kitten()
        {
         
            step_eat = 3;
            step_health = 1;
            step_water = 2;
            interval = 70;
            Eat = Water = Health = 108;

        }
    }
    class Dog : Person
    {
        public Dog()
        {
            
            step_eat = 4;
            step_health = 1;
            step_water = 3;
            interval = 100;
            Eat = Water = Health = 108;

        }
    }
}
