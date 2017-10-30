using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {

      private IFace mystack = new LinkedStack();

        static void Main(string[] args)
        {   //allows the user to continue to use the program over and over until they are satisfied
            Calculator calc = new Calculator();
            //sets the program to keep running untill it is set to false
            bool playagain = true;
            //informs the user how to play the program
            System.Console.WriteLine("Postfix Calculator. Recognizes these operators: + - * /");
            //this is the loop that repeats the program
            while (playagain)
            {
                //calls the next method
                playagain = calc.DoCalculation();
            }
            //after the user is done, this message is played
            System.Console.WriteLine("Buh Bye.");

        }

        //determines if the program is to be run again
        private bool DoCalculation()
        {
            //gathers user input
            string userinput;
            //informs the user how to exit
            System.Console.WriteLine("Please enter q to quit");
            //demonstrates how to use this calc program
           // System.Console.WriteLine("Example input: 2 2 +");
            System.Console.Write("> ");
            userinput = Console.ReadLine();
            //ends the program
            if((userinput == "q") || (userinput == "Q"))
            {
                return false;
            }
            string output; // this is what gives us our end message, or possible error message
            try
            {
                //retrieves the output of the program
                output = PostFixInput(userinput);
            }
            catch(Exception)
            {
                // if an error occures this will throw it
                output = PostFixInput(userinput);
            }
            
            //this outputs the end result, sets the program true and then restarts the program
            System.Console.WriteLine("\n\t>>> {0} = {1}", userinput, output);
            return true;
        }

    //gathers and parses the users input and determines if it is "good" input 
        public string PostFixInput(string userinput)
        {
            string e; // this will be our error message
            if((userinput == null) || (userinput == ""|| (userinput == " ")))// we will not tolerate nulls or empty inputs
                {
                e = "Null or the empty string are not valid postfix expressions.";
                mystack.Clear();
                return e;
            }
           // mystack.Clear();

            string s;//determines action for the digits
            double a = 0.0;
            double b = 0.0;
            double c = 0.0;

            char[] deliChars = { ' ' }; ///parses based on spaces between the variables
            string[] vari = userinput.Split(deliChars);

            try //now is the first part of the string really a double, or are you just testing our program
            {
                a = Convert.ToDouble(vari[0]);
                mystack.Push(a);
            }
            catch (FormatException)
            {
                e = "Improper input format. Stack became empty when expecting first operand.";
                mystack.Pop();
                return e;
            }
            try// now is the second part of the string reallly a double, or you trying to trick us
            {
                b = Convert.ToDouble(vari[1]);
                mystack.Push(b);
            }
            catch (FormatException)
            {
                e = "Improper input format. Stack became empty when expecting second operand.";
                mystack.Pop();
                return e;
            }
            s = vari[2];
            mystack.Push(s);

            if (s.Length > 1) // checks to see if the last bit of the string is an operator, if you "accidently" put more chars this catches that
            {
                e = "Input Error " + s + " is not an allowed number or operator";
                mystack.Pop();
                return e;
            }
            else if (s.Equals("+") || s.Equals("-") || s.Equals("*") || s.Equals("/")) // allows the following 
            {
               c = DoOperation(a, b, s);
                mystack.Push(c);
                return c.ToString();
            }
            else // you must have not done the above else if statement to get here
            {
                e = "Improper operator: " + s + ", is not one of +, -, *, or /";
                return e; 
            }
            
        }
        public double DoOperation(double a, double b, string s) // This is where the Arithemtic happens, ta da its a form of math
        {
            double c = 0.0;
            if(s.Equals("+"))
            {
                c = (a + b);
            }
            else  if(s.Equals("-"))
            {
                c = (a - b);
            }
            else if(s.Equals("*"))
            {
                c = (a * b);
            }
            else if(s.Equals("/"))// you reaally trying to divide by zero, that creates a black hole, which this program cant handle
            {
                if (b == 0)
                {
                    System.Console.WriteLine("Can't Divide by zero");
                }
                else
                    c = (a / b);
            }
            else //if you forget something, Im just gunna send it back at ya
            {
                c = a;
            }
            return c;// returns the final product
        }

    }
}
