﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Raven_Queens_Crown
{
    class Raven_Queens_Crown
    {
        static void Main(string[] args)
        {
            //string answer = "";

            //answer = Console.ReadLine();

            //while (answer != "9999")

            Console.WriteLine("You are standing in a busy street in *Base Point*, you must find The Raven Queens Crown. To travel north to the volcano to the press \'n\' To check the Mountain in the west press \'w' " +
                "To search the southern forest press \'s\' To plunder the eastern castle press \'e\' ");
            string direction = Console.ReadLine();
                Intro();
            //switch (direction.ToLower())
            //{


            //        //Desert();
            //        //} 
            //}

            //Console.WriteLine("You have found the Raven Queens Crown it was in {place}");
        }

        public static void Intro()
        {
            Console.WriteLine("You are standing in a busy street in *Base Point*, you must find The Raven Queens Crown. To travel north to the volcano to the press \'n\' To check the Mountain in the west press \'w' " +
            "To search the southern forest press \'s\' To plunder the eastern castle press \'e\' ");
            string direction = Console.ReadLine();
            switch (direction.ToLower())
            {
                case "n":
                    Volcano();
                    Intro();
                    break;
                case "w":
                    Mountain();
                    Intro();
                    break;
                case "s":
                    Forest();
                    Intro();
                    break;
                case "e":
                    Castle();
                    Intro();
                    break;
            }
        }




















        public static void Volcano()
        {
            //Console.WriteLine("\nYou have finally found yourself at the entrance of Mount Doom, the only active volcano in (NAME OF PLACE)");
            //Console.WriteLine("Inside, you see a bridge that spans across a pit of molten hot lava.");
            //Console.WriteLine("On the other end of the bridge, you notice a sword, gleaming and blinding.");

            StreamReader sr = new StreamReader(@"H:\Professional Practice\Raven-Queens-Crown\Raven Queens Crown\Faizel's Info\Story.txt");

            string questions;

            string sentence = "";

            questions = sr.ReadToEnd();

            foreach (char display in questions)
            {
                Thread.Sleep(75);
                Console.Write(display);
            }

            //Console.WriteLine(sentence.TrimEnd());
            Console.ReadLine();




























        }
















































        public static void Forest()
        {
            Console.WriteLine($"You are on the edge of Barewood Forrest.\n");

            //Console.WriteLine($"In the distance you see a slight movment.");
            //Console.ReadLine();

            Console.WriteLine($"Do you enter the forrest");
            string enterForrest = Console.ReadLine();
            enterForrest = enterForrest.ToLower();
            if (enterForrest == "yes")
            {
                Console.WriteLine($"\nAll areound you are Barkless Trees, they streatch up as if to cover the sky.\n");
                Console.WriteLine($"As you enter the Forrest your eye catches see a slight movment in the distance in front of you");
                Console.WriteLine("Do you go foward?\n");
                string foward = Console.ReadLine();
                if (foward.ToLower() == "yes")
                {
                    Console.Clear();
                    Console.WriteLine("\nAs you approch, it is reveled to be a elf.\n");
                    Console.WriteLine("Possibly of WoodElf decent as he is earthy in apparence. With light brown hair on light skin and green robes to match vibrant green eyes");
                    Console.WriteLine("He greets you warmly.Closer you see that the elf seems old in age.\n");

                    Console.WriteLine("He Speacks to you\n[ENTER]");
                    Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Hello! What are you up to in the forrest?\n");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Hi, I am here looking for a missing item. I hered that the cultprate could have been seen in this area.\n");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Oh, \nI feel I remeber seeing another new face like yourself just a few days ago.");
                    Console.WriteLine("I think he was somewhere on the West of the forrest");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nThank you for that information, goodbye!");

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nGoodBye");

                    Console.WriteLine("[ENTER]");
                    Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("You are now by yourself in the middle of the forrest.");
                    Console.WriteLine("What direction do you want to go?\n");
                    Console.WriteLine("[n] North");
                    Console.WriteLine("[e] East");
                    Console.WriteLine("[s] South");
                    Console.WriteLine("[w] West");
                    Console.Write("Your Direction?: ");
                    string way = Console.ReadLine();

                    switch (way.ToLower())
                    {
                        case "n":
                            Console.WriteLine("You North and are sorrounded by more trees");
                            break;
                        case "e":
                            Console.WriteLine("You East and are sorrounded by more trees");
                            break;
                        case "s":
                            Console.WriteLine("You South and are sorrounded by more trees");
                            break;
                        case "w":
                            Console.WriteLine("By a sinkHole with vines");
                            break;

                    }
                }
                else if (foward.ToLower() == "no" || foward.ToLower() == "")
                {
                    Console.WriteLine("Where do you want to go?");

                }
            }

            else
            {
                Console.WriteLine("Honey, why are you here then");
            }
            Console.ReadLine();
        }

















    }



















































        public static void Castle()
        {

            //Objective of the game is to find the crown

            Console.WriteLine("You have reached the outskirts of a Castle. /nDo you want to a)Explore the castle in search of the crown /nb)Search the grounds");
            char outskirts = Convert.ToChar(Console.ReadLine());

            if (outskirts == 'a')
            {
                Console.WriteLine("You enter the Castle " +
                    "it is dark inside to your left is a torch to grab the torch press \'t\' to ignore the torch and carry on walking press \'w\'");
                char torch = Convert.ToChar(Console.ReadLine());

                if (torch == 'b')
                {
                    Console.WriteLine("You picked up the torch");
                }
            else
            {
                Console.WriteLine("To your left is staircase that leads down to what looks like a celler, to your right is a staircase that leads upwards");
                Console.WriteLine("Do you want to /na) Walk down the stairs to the celler /nb)Walks up the stairs");
            }

                Console.WriteLine("\nTo your left are some poison darts to pick them up press \'p\'");
                string poison = Console.ReadLine();

                if (poison == "p")
                {
                    string inventory = poison;
                    Console.WriteLine("You pick up the poison darts, they are now added to your inventory, to throw press \'p\'");
                }

                //if user moves forward
                Console.WriteLine("A cat bounds forward");
                char cat = Convert.ToChar(Console.ReadLine());
                if (cat == 'p')
                {
                    Console.WriteLine("You threw poison darts at the cat, its a direct hit");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You died");
                    Console.ReadLine();
                }

            }















































        }



















































        public static void Mountain()
        {













































        }

























































        public static void Desert()
        {

















































        }
        
    }
}
