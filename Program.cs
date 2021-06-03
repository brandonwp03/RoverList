using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class Program
    {
        static void Main(string[] args)
        {
            RoverList<string> list = new RoverList<string>();

            // TODO:  Implement the RoverList class
            // TODO:  Create a RoverList and then fill it with 16 words

            // TODO:  Print out the list
            list.Add(data:"apple");
            list.Add(data:"bananana");
            list.Add(data:"strawberry");
            list.Add(data:"pear");
            list.Add(data:"carrot");
            list.Add(data:"watermelon");
            list.Add(data:"blueberry");
            list.Add(data:"raspberry");
            list.Add(data:"lettuce");
            list.Add(data:"celery");
            list.Add(data:"tomato");
            list.Add(data:"potato");
            list.Add(data:"green bean");
            list.Add(data:"pea");
            list.Add(data:"pumpkin");
            list.Add(data:"pepper");

            // TODO:  Prompt the user to input words, add those words to the list until they enter the word "done"
            // TODO:  Print out the list
            list.ListNodes();
            Console.WriteLine list;


            // TODO:  Prompt the user to input words, add those words to the FRONT of the list until they enter the word "done"
            Console.WriteLine"Input words!";

            // TODO:  Print out the list
            Console.WriteLine list;
            // TODO:  Remove every word with an odd length
            
            // TODO:  Print out the list
            Console.WriteLine list;
            // TODO:  Clear the list
            list = null;
            // TODO:  Print out the list
            Console.WriteLine list;


        }
    }
}
