using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of collections!!!!!");
            DisplayList();
            DisplayStack();
            DisplayDictionary();
            DisplayQueue();
        }
        private static void DisplayList()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Example on list ");

            //To create list
            List<string> itemList = new List<string>();

            //Adding objects to list
            itemList.Add("Exo");
            itemList.Add("Bts");
            itemList.Add("Blackpink");
            itemList.Add("WannaOne");
            itemList.Add("Twice");
            itemList.Add("Super Junior");

            //To iterate the items in list
            foreach(var element in itemList)
            {
                Console.WriteLine("Items are :" + element);
            }
        }

        private static void DisplayStack()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Example on queue ");

            //Creation of stack
            Stack<string> stackList = new Stack<string>();
            stackList.Push("Harry");
            stackList.Push("Ron");
            stackList.Push("Malfoy");
            stackList.Push("Lovegood");
            stackList.Push("Hogwarts");
            string poppedElement = stackList.Pop();

            //To iterate the items in list
            foreach (var element in stackList)
            {
                Console.WriteLine("Items are :" + element);
            }
            Console.WriteLine("Popped element is : " + poppedElement);

        }

        private static void DisplayDictionary()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Example on dictionary ");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Teji");
            dictionary.Add(2, "Lee Minho");
            dictionary.Add(3, "Taemin");
            //Using key
            Console.WriteLine("To access using key(key = 2) : " + dictionary[2]);
            //To iterate the items in list
            foreach (var element in dictionary)
            {
                Console.WriteLine("key : " +element.Key + "& value : " + element.Value);
            }

        }

        private static void DisplayQueue( )
        {
            Queue queueList = new Queue();
            //Adding items in queue
            queueList.Enqueue("London");
            queueList.Enqueue("Toronto");
            queueList.Enqueue("Greece");
            //iterating the items
            foreach (var element in queueList)
            Console.WriteLine("Queue consists of : " + element);
            //to remove a value
            var obj = queueList.Dequeue();
            Console.WriteLine("The removed value is : {0} " + obj);
            foreach (var element in queueList)
                Console.WriteLine("Current queue consists of : " + element);

        }

    }
}
