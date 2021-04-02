using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace defaultp
{
    class cars
    {
        private string model;
        private string make;
        private int year;
        public string Make
        {
            get 
            { 
                return make; 
            }
            set 
            { 
                make = "Tesla"; 
            }
        }
        public string Model
        {
            get 
            { 
                return model; 
            }
            set 
            { 
                model = "Model 3"; 
            }
        }
        int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public void Car1(string ma, string mo, int y)
        {
            
            this.Make = Make;
            this.Model = Model;

            Console.WriteLine($"Well, your car is a {y} {Make} {Model}. Good Make and Model!!");
        }
    }
}
