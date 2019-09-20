using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			//type
			//value
			/*
			 *123 integer
			 *12.8764 double
			 * ali string 
			 *  true bool
			 */

			//type's intro
			//int number = 123;
			//double number2 = 123.0978;
			//string name = "ali";
			//bool isAgree = true;

			//Console.WriteLine(number);
			//Console.WriteLine(number2);
			//Console.WriteLine(name);
			//Console.WriteLine(isAgree);


			//operators 
			/*
			 *+,-,/,*
			 *<,>,>=,<=,&,|
			 * 
			 */
			//int number1 = 10;
			//int number2 = 20;
			//int total = number1 + number2;
			//Console.WriteLine(total);

			//int numer1 = 0;
			//bool isLess = numer1 == 1 | numer1<=1;
			//Console.WriteLine(isLess);


			//if else, elseif

			//user input

			//Console.WriteLine("Enter your mobile choice");
			//string PhoneChoice = Console.ReadLine();
			//if (PhoneChoice.ToLower().Equals("iphone"))
			//{
			//	Console.WriteLine("200k");
			//}

			//else if(PhoneChoice.ToLower().Equals("nokia"))
			//{
			//	Console.WriteLine("50k");
			//}
			//else
			//{
			//	Console.WriteLine("koi v da do");
			//}

			//mobile shop




			/*
			 * Samsung
			 * Apple
			 * Huawei
			 * Nokia
			 * Sony
			 * HTC
			 * Motorola
			 * Lenovo
			 * china
			 */

			/*
			 * 50k 100k ,Samsung, apple, Huawei
			 * 30k 50k nokia,sony htc, lenovo 
			 * 25k 30k motorola,huawei,htc,china
			 * 20k 25k china,htc,nokia
			 * 15k 20k china,nokia 
			 * 10k 15k china
			 */


			Console.WriteLine("G Sir ap n kn sa mobile phone lyna h? ");
			Console.WriteLine("1->Samsung");
			Console.WriteLine("2->China");
			Console.WriteLine("3->Apple");
			Console.WriteLine("4->Nokia");
			Console.WriteLine("5->Lenovo");
			Console.WriteLine("6->Motorola");
			Console.WriteLine("7->Huawei");
			Console.WriteLine("8->yr yi hmra pass mobile hny \n axh ap apni range bta dyna kindly add you range in Ke.g 10k means 10000");
			string userchoice = Console.ReadLine();
			switch (userchoice)
			{
				case "1":
					Console.WriteLine("Price List");
					Console.WriteLine("Samsung Galaxy A10s Rs. 9,490");
					Console.WriteLine("Samsung Galaxy Note 10 + Rs. 75,050");
					break;
				case "2":
					Console.WriteLine("Price List");
					Console.WriteLine("QA abc 10k");
					Console.WriteLine("Samsung Galaxy Note 10 + Rs. 75,050");
					break;
				case "3":
					break;
				case "4":
					break;
				case "5":
					break;
				case "7":
					break;
				default:

					if (Convert.ToInt32(userchoice.Split('k')[0])>=50 && Convert.ToInt32(userchoice.Split('k')[0])<=100)
					{
						Console.WriteLine("Price List");
						Console.WriteLine("1-?Samsung Galaxy A10s Rs. 9,490");
						Console.WriteLine("2->Samsung Galaxy Note 10 + Rs. 75,050");

						Console.WriteLine("3->Iphone x Rs. 9,490");
						Console.WriteLine("4->Iphone y Rs. 75,050");
					}
					else if (Convert.ToInt32(userchoice.Split('k')[0]) >= 10 || Convert.ToInt32(userchoice.Split('k')[0]) <= 15)
					{
						Console.WriteLine("Price List");
						Console.WriteLine("1->QA abc 10k");
						Console.WriteLine("do you want mobile y/n");
				

						
					}

					break;
					

			}













			Console.WriteLine("press any key to stop the program");
			Console.ReadKey();
		}
	}
}
