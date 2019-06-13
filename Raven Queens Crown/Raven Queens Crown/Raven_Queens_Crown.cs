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
        static void Main()
        {
            string[] inventory = new string[5] { "Empty", "Empty", "Empty", "Empty", "Empty" };

            //Intro();
           // Mountain();
            //Game(inventory);
        }


        public static void Intro()
        {
            /*Console.WriteLine("You are standing in a busy street in *Base Point*, you must find The Raven Queens Crown. To travel north to the volcano to the press \'n\' To check the Mountain in the west press \'w' " +
            "To search the southern forest press \'s\' To plunder the eastern castle press \'e\' ");*/

            Console.WriteLine("\nYou are standing in a busy street in *Base Point*, you must find The Raven Queens Crown.\n");
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


        public static void Mountain()
        {

            string temp, temp1;
            bool Apple = false;
            bool Rabbit = false;
            bool Bow = false;

            //Console.WriteLine("Welcome to the Mountain, there have two way can reach the top. One is follow the sighn next the road that is easy one but will take more time. Another one is through the cave which is danger than the normal road, however, it will save time.");
            //Console.WriteLine("Choose the Road or Cave?");
            //temp = Console.ReadLine();

            do
            {
                do
                {
                    Console.WriteLine("You are enter the mountain, a lot of fruit tree next the road, do you want to get something?(Yes or No)");
                    temp = Console.ReadLine();
                    if (temp == "Yes")
                    {
                        Console.WriteLine("You got three apples.");
                        Apple = true;
                        Thread.Sleep(500);
                    }
                    else
                    {
                        Apple = false;
                    }

                    Console.WriteLine("You saw some rabbit on the front, do you want catch them?(Yes or No)");
                    temp = Console.ReadLine();
                    Thread.Sleep(500);
                    if (temp == "Yes")
                    {
                        Console.WriteLine("What item can be used as bait?");
                        temp1 = Console.ReadLine();
                        Thread.Sleep(500);
                        if (temp1 != "Apple")
                        {
                            Console.WriteLine("The Rabbit run away.");
                            Thread.Sleep(500);
                        }
                        else
                        {
                            if ((temp1 == "Apple") && (Apple == true))
                            {
                                Console.WriteLine("You spent two apples and got a rabbit.");
                                Thread.Sleep(500);
                                Rabbit = true;
                            }
                            else
                            {
                                Console.WriteLine("You do not have any apple");
                                Thread.Sleep(500);
                            }
                        }
                    }

                    Console.WriteLine("You keep move to the top of mountain, there have a house right side of the road.");
                    Console.WriteLine("The house look like a lone time no one live, do you want go in the house?(Yes or No)");
                    temp = Console.ReadLine();
                    while (temp == "No")
                    {
                        Console.WriteLine("However, the sky are truning to drak, sleep outside is no safe.");
                        Console.WriteLine("Do you want go in the house?");
                        temp1 = Console.ReadLine();
                        if (temp1 == "Yes")
                        {
                            break;
                        }
                    }

                    Console.WriteLine("You sit on a chair and saw a note on the table 'be careful the tiger, do not fight it face to face, use bow and arrow'.");
                    Thread.Sleep(500);
                    Console.WriteLine("Sounds like have weapons in the house, do you want to search the house?(Yes or No)");
                    temp = Console.ReadLine();
                    Thread.Sleep(500);
                    if (temp == "Yes")
                    {
                        Console.WriteLine("You found a bow and some arrow under the bed.");
                        Bow = false;
                        Thread.Sleep(500);
                    }
                    Console.WriteLine("You stay one night in here.");
                    Thread.Sleep(500);


                    Console.WriteLine("You know 'The majority of these zzz's happen during the day, because tigers in the wild do most of their prowling at night, aided by night vision that's six times better than humans'. So you need to make a trap at the day time then can catch the tiger of prowling at night, hopefully.");
                    Thread.Sleep(500);
                    Console.WriteLine("Check the weapon and other item need to use.");
                    Console.WriteLine("Perpare enough to move forward or go back?(Yes or No)");
                    Thread.Sleep(500);
                    temp = Console.ReadLine();

                } while (temp != "Yes");

                Console.WriteLine("You found a hole which have enough room to snare the tiger, one more thing need to do is put some bait on the hole.");
                Console.WriteLine("What item can bu used as bait?");
                temp = Console.ReadLine();
                Thread.Sleep(500);
                if (temp == "Rabbit")
                {
                    Console.WriteLine("All done, waiting for the tiger coming...");
                    Thread.Sleep(500);
                }

                Console.WriteLine("...");
                Thread.Sleep(500);
                Console.WriteLine("...");
                Thread.Sleep(500);
                Console.WriteLine("...");
                Thread.Sleep(500);

                Console.WriteLine("The tiger drop in the hole, you can kill it now.");
                Console.WriteLine("Which weapons you can use?");
                Console.WriteLine("Choose correct weapon to kill to or go to somewhere to find a weapon");
                temp = Console.ReadLine();
                Thread.Sleep(500);
                if (temp == "Bow")
                {
                    Console.WriteLine("You killed the tiger");

                }

            } while (temp != "Bow");

            Console.WriteLine("right");
            Console.WriteLine("You killed the tiger");
            temp = Console.ReadLine();
            Console.WriteLine("Finish");
            Console.ReadLine();

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

        public static void Desert()
        {

















































        }

        public static void Volcano()
        {
            //int countStory = 0, countInventory = 0;

            //StreamReader story = new StreamReader(@"H:\Raven-Queens-Crown\Raven Queens Crown\Faizel's Info\Story.txt");
            //StreamReader store = new StreamReader(@"H:\Raven-Queens-Crown\Raven Queens Crown\Faizel's Info\Store in Inventory.txt");
            //string storyLine, useInventory, storeInventory, use = "Use";
            //storyLine = story.ReadToEnd();
            //storeInventory = store.ReadToEnd();
            //string[] storyLines = storyLine.Split('-');
            //string[] inventory = storeInventory.Split(',');
            //foreach (char displayStoryLine in storyLines[countStory])
            //{
            //    Thread.Sleep(25);
            //    Console.Write(displayStoryLine);
            //}
            //countStory++;
            //string answer = Console.ReadLine();
            //answer = answer.Replace(',', ' ');
            //string[] answerCheck = answer.Split(' ');
            //foreach (string user in answerCheck)
            //{
            //    foreach (string pick in inventory)
            //    {
            //        if (user == pick)
            //        {

            //        }
            //    }
            //}

            ///*
            //foreach (char display in question)
            //{
            //    Thread.Sleep(75);
            //    Console.Write(display);
            //}

            ////Console.WriteLine(sentence.TrimEnd());*/
            //Console.ReadLine();


            string path;
            int death=0;
            Console.Clear();
            Console.WriteLine("**You have entered the volcano Territory**\n");
            Console.WriteLine("Infront of you there are 3 bridges conecting your land to an unknown location. \nAs the ash from the volcano is blocking your view to the other side.");
            Console.WriteLine("One of them has to lead to the volcano, right?!\n[ENTER]");
            Console.ReadLine();
            Console.WriteLine("The bridges look raggedy and old as the wood is slightly rotted. But the Iron linking them looks secure.\n[ENTER]");
            Console.ReadLine();
            Console.WriteLine("The bridge chooices are as followed: \nThe first one is at the far right, in the distance it seems to vear to the right.");
            Console.WriteLine("The Second is in the middle and also vears to the right");
            Console.WriteLine("Where as the third bridge seems to be going straght towards the volcano.\n[ENTER]");
            Console.ReadLine();
            Console.Write("Do you choose bridge 1, 2 or 3: ");
            path = Console.ReadLine();

            if (path == "2")
            {
                Console.Clear();
                Console.WriteLine("**You Dye**\n[ENTER]");
                Console.ReadLine();
                death = death + 1;
                Console.Clear();
                Main();
            }

            if (path == "1")
            {
                Console.Clear();
                Console.WriteLine("**You Dye**\n[ENTER]");
                Console.ReadLine();
                death = death + 1;
                Console.Clear();
                Main();
            }

            if (path == "3")
            {
                Console.Clear();
                Console.WriteLine("You chose correctly! You have reached the volcano.");
                Console.WriteLine("you cross the bridge and you see a path that leads to a ricketty shack.\n");
                //Console.ReadLine();
                Console.Write("Do you approach the scack");
                string shack = Console.ReadLine();
                bool enterShack = false;
                if (shack.ToLower() == "no")
                {
                    enterShack = false;
                }
                else
                {
                    enterShack = true;
                }
                while (enterShack == false)
                {

                    if (shack.ToLower() == "no")
                    {
                        Console.WriteLine("Isnt this your only Lead?");
                        Console.Write("Do you approach the scack: ");
                        shack = Console.ReadLine().ToLower();

                    }
                    else
                    {
                        Console.WriteLine("So you are just quitting?");
                        
                    }
                }

                if(enterShack == true)
                {
                    Console.WriteLine("enter shack");
                    enterShack = true;
                    Console.WriteLine("Inside you see a quaint set up. With only a couple pieces of furniture. A single bed and desk.\n");
                    Console.Write("Do you investigate?: ");
                    string invest = Console.ReadLine();
                    if (invest.ToLower() == "yes")
                    {
                        Console.WriteLine("Investigate");
                    }
                    else
                    {
                        Console.WriteLine("Okay, you can just stand there.");
                        Console.Write("Do you leave the shack then?: ");
                        string leaveShack = Console.ReadLine();
                        if (leaveShack.ToLower() == "yes")
                        {
                            enterShack = false;
                        }
                    }
                }
            }
            Console.ReadLine();




























        }

        public static void Game(string[] inventory)
        {
            int[,] map = new int[5, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 }, { 21, 22, 23, 24, 25 } };
            int[] position = new int[1];
            int[] check = new int[1];
            int x = 2, y = 2;
            bool exit = false;

            string input;

            position[0] = map[2, 2];

            Console.WriteLine("\nn - NORTH\ns - SOUTH\ne - EAST\nw - WEST\n\ni - INVENTORY\n\nq - QUIT\n");
            Console.WriteLine($"\n{x} , {y}\n");
            Console.WriteLine(position[0]);
            Console.WriteLine("");
            input = Console.ReadLine().ToLower();

            while (exit == false)
            {
                Console.Clear();

                switch (input)
                {
                    case "n":

                        check[0] = position[0] - map[0, 4];

                        if ((check[0] == map[0, 1]) || (check[0] == map[0, 2]) || (check[0] == map[0, 3]))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"\n{x} , {y}\n");
                            Console.WriteLine(position[0]);
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nYou cannot go there\n");

                            break;
                        }

                        else
                        {
                            position[0] = position[0] - map[0, 4];
                            check[0] = position[0];
                            x = x + 0;
                            y = y + 1;

                            CheckPosition(position, map, input, inventory);

                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nn - NORTH\ns - SOUTH\ne - EAST\nw - WEST\n\ni - INVENTORY\n\nq - QUIT\n");
                            Console.WriteLine($"\n{x} , {y}\n");
                            Console.WriteLine(position[0]);
                            Console.WriteLine("");
                        }
                        break;

                    case "s":

                        check[0] = position[0] + map[0, 4];

                        if ((check[0] == map[4, 1]) || (check[0] == map[4, 2]) || (check[0] == map[4, 3]))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"\n{x} , {y}\n");
                            Console.WriteLine(position[0]);
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nYou cannot go there\n");

                            break;
                        }

                        else
                        {
                            position[0] = position[0] + map[0, 4];
                            check[0] = position[0];
                            x = x + 0;
                            y = y - 1;

                            CheckPosition(position, map, input, inventory);

                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nn - NORTH\ns - SOUTH\ne - EAST\nw - WEST\n\ni - INVENTORY\n\nq - QUIT\n");
                            Console.WriteLine($"\n{x} , {y}\n");
                            Console.WriteLine(position[0]);
                            Console.WriteLine("");
                        }

                        break;

                    case "w":

                        check[0] = position[0] - map[0, 0];

                        if ((check[0] == map[1, 0]) || (check[0] == map[2, 0]) || (check[0] == map[3, 0]))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"\n{x} , {y}\n");
                            Console.WriteLine(position[0]);
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nYou cannot go there\n");

                            break;
                        }

                        else
                        {
                            position[0] = position[0] - map[0, 0];
                            check[0] = position[0];
                            x = x - 1;
                            y = y + 0;

                            CheckPosition(position, map, input, inventory);

                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nn - NORTH\ns - SOUTH\ne - EAST\nw - WEST\n\ni - INVENTORY\n\nq - QUIT\n");
                            Console.WriteLine($"\n{x} , {y}\n");
                            Console.WriteLine(position[0]);
                            Console.WriteLine("");
                        }

                        break;

                    case "e":

                        check[0] = position[0] + map[0, 0];

                        if ((check[0] == map[1, 4]) || (check[0] == map[2, 4]) || (check[0] == map[3, 4]))
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"\n{x} , {y}\n");
                            Console.WriteLine(position[0]);
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nYou cannot go there\n");

                            break;
                        }

                        else
                        {
                            position[0] = position[0] + map[0, 0];
                            check[0] = position[0];
                            x = x + 1;
                            y = y + 0;

                            CheckPosition(position, map, input, inventory);

                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\nn - NORTH\ns - SOUTH\ne - EAST\nw - WEST\n\ni - INVENTORY\n\nq - QUIT\n");
                            Console.WriteLine($"\n{x} , {y}\n");
                            Console.WriteLine(position[0]);
                            Console.WriteLine("");
                        }

                        break;

                    case "q":

                        Console.WriteLine("Are you sure you want to quit? (Y/N)");
                        input = Console.ReadLine().ToLower();

                        if (input == "y")
                        {
                            exit = true;
                            Console.WriteLine("\nPress enter to continue\n");
                        }

                        else
                        {
                            input = "";
                            Console.WriteLine("\nPress enter to continue\n");
                        }

                        break;

                    case "i":
                        DisplayInventory(inventory);
                        break;

                    default:

                        CheckPosition(position, map, input, inventory);

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\nn - NORTH\ns - SOUTH\ne - EAST\nw - WEST\n\ni - INVENTORY\n\nq - QUIT\n");
                        Console.WriteLine($"\n{x} , {y}\n");
                        Console.WriteLine(position[0]);
                        Console.WriteLine("");


                        break;
                }

                input = Console.ReadLine().ToLower();
            }
        }

        public static void CheckPosition(int[] position, int[,] map, string input, string[] inventory)
        {
            bool enter = true;

            while (enter == true)
            {
                if (position[0] == map[1, 3])
                {
                    Console.WriteLine("\nYou are entering the Volcano. Do you want to proceed? (Y/N)\n");
                    input = Console.ReadLine().ToLower();

                    if (input == "y")
                    {
                        Volcano();
                    }

                    else
                    {
                        enter = false;
                    }
                }

                else if (position[0] == map[1, 1])
                {
                    Console.WriteLine("\nYou are entering the Desert. Do you want to proceed? (Y/N)\n");
                    input = Console.ReadLine().ToLower();

                    if (input == "y")
                    {
                        Desert();
                    }

                    else
                    {
                        enter = false;
                    }
                }

                else if (position[0] == map[3, 1])
                {
                    Console.WriteLine("\nYou are entering the Mountains. Do you want to proceed? (Y/N)\n");
                    input = Console.ReadLine().ToLower();

                    if (input == "y")
                    {
                        Mountain();
                    }

                    else
                    {
                        enter = false;
                    }
                }

                else if (position[0] == map[3, 2])
                {
                    Console.WriteLine("\nYou are entering the Forest. Do you want to proceed? (Y/N)\n");
                    input = Console.ReadLine().ToLower();

                    if (input == "y")
                    {
                        Forest();
                    }

                    else
                    {
                        enter = false;
                    }
                }

                else if (position[0] == map[3, 3])
                {
                    Console.WriteLine("\nYou are entering the Castle. Do you want to proceed? (Y/N)\n");
                    input = Console.ReadLine().ToLower();

                    if (input == "y")
                    {
                        Castle();
                    }

                    else
                    {
                        enter = false;
                    }
                }

                else
                {
                    break;
                }
            }
        }

        public static void DisplayInventory(string[] inventory)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(inventory[i]);
            }
        }

        public static void Inventory(string[] inventory, string item)
        {
            string replace = "", drop = "";
            bool empty = true;

            for (int i = 0; i < inventory.Length; i++)
            {
                empty = true;

                if (inventory[i].Contains("Empty"))
                {
                    inventory[i] = item;
                    empty = false;
                    break;
                }
            }

            if (empty == true)
            {
                Console.WriteLine("\nYour inventory is full, do you want to drop something?\n");
                drop = Console.ReadLine();

                if (drop == "y")
                {
                    Console.Clear();
                    DisplayInventory(inventory);
                    Console.Write("\n\nPlease take a look at your inventory above decide what you want to replace\n\nItem to swap: ");
                    replace = Console.ReadLine();
                }

                for (int i = 0; i < inventory.Length; i++)
                {
                    if (replace.ToLower() == inventory[i].ToLower())
                    {
                        inventory[i] = item;
                        break;
                    }
                }

                Console.Clear();

                DisplayInventory(inventory);
            }

            Console.WriteLine("\nPress enter to continue\n");
            Console.ReadLine();

            
        }
    }
}    