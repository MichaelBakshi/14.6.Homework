using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._06.Homework
{
    class Computer
    {
        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn;
        public bool isTurnOff;


        public int TellMeThePrice ()
        {
            return price;
        }
      
        public float TellMeTheScreenSize()
        {
            return screenSize;
        }
        public void TurnOn()
        {
            
        }

        public void TurnOff()
        {

        }

        public void AddProcessor()
        {

        }

        public override string ToString()
        {
            return $"";
        }

    }
}
