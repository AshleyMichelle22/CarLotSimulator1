using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    { 
         public Car()// default constructor
         { 
    
         }
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
         //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        public Car(string make, string model, int year)
        {

            make = make;
            model = model;
            year = year;

        }
        public int year { get; set; }  
        public string make { get; set; }
        public string model { get; set; }
        public string EngineNoise { get; set; }    
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }


        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine(engineNoise);
        }
        public void MakeHonkNoise(string honkNoise)
        { 
            Console.WriteLine(honkNoise);
        }
        









    }
}
