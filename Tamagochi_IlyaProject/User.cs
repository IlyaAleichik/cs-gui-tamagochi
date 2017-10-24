using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagochi_IlyaProject
{



    abstract class Person : IAction
    {
        protected int interval;
        protected int Eat;
        protected int Water;
        protected int Health;
        protected int step_eat, step_water, step_health;
        protected int add = 10;
      
        
        public int getAdd()
        {
            return add;
        }
        public int getInterval() {
            return interval;
        }
        public int getStep_eat()
        {
            return step_eat;
        }
        public int getStep_water()
        {
            return step_water;
        }
        public int getStep_health()
        {
            return step_health;
        }

    }

   


    interface IAction
    {
       
        int getAdd();
   
        int getInterval();

        int getStep_eat();

        int getStep_water();

        int getStep_health(); 
    }


 
  










}
       


    





    

