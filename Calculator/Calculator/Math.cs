using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Math 
    {
        
        public void Domath()
        {
             Add adding = new Add();
            Subtract subtract = new Subtract();
            Divide divide = new Divide();
            Multiply multiply = new Multiply();
            Console.WriteLine("Enter first number");
            int numberone = Convert.ToInt32(Console.ReadLine());        
            Console.WriteLine("Enter another number");
            int numbertwo = Convert.ToInt32(Console.ReadLine());          
            Console.WriteLine("1.Add,2.Subtract,3.Divide,4.Multiply");
            
            string mathchoice = Console.ReadLine();
            switch(mathchoice)
            {
                case "1":
                    adding.Addnumbers(numberone,numbertwo);
                    break;
                case "2":
                    subtract.Subtractnumbers(numberone, numbertwo);
                    break;
                case "3":
                    divide.Dividenumbers(numberone, numbertwo);
                    break;
                case "4":
                    multiply.Multiplynumbers(numberone, numbertwo);
                    break;
                    
            }
       

            
        }
    }
}
