﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuUITools
{
	public class Menu
	{
		private String[] elementy;
		public int najdluzszyElement = 0;

		public void Konfiguruj(string[] elementyMenu)
		{
			if (elementyMenu.Length <= 100)
			{
				elementy = elementyMenu;
				for (int i = 0; i < elementy.Length; i++)
				{
					if (elementyMenu[i].Length > najdluzszyElement)
					{
						najdluzszyElement = elementyMenu[i].Length;
					}
				}
			}
			else
			{
				elementy = new string[0];
			}
		}

		public void Konfiguruj(List<string> lista)
		{
			elementy = lista.ToArray();
			Konfiguruj(elementy);

		}
		public int Wyswietl()
		{
			// Console.Clear();
			int wybrany = 0;
			if (elementy != null)
			{
				ConsoleKeyInfo keyInfo;
				Console.BackgroundColor = ConsoleColor.DarkBlue;

				do
				{
					Console.SetCursorPosition(0, 0);
					for (int i = 0; i < elementy.Length; i++)
					{
						if (i == wybrany)
						{
							Console.BackgroundColor = ConsoleColor.Blue;
						}
						else
						{
							Console.BackgroundColor = ConsoleColor.DarkBlue;
						}
						Console.WriteLine(elementy[i].PadRight(najdluzszyElement + 2));
					}


					keyInfo = Console.ReadKey();

					if ((keyInfo.Key == ConsoleKey.UpArrow && wybrany == 0) || keyInfo.Key == ConsoleKey.End)
					{
						wybrany = elementy.Length - 1;
					}
					else if (keyInfo.Key == ConsoleKey.UpArrow && wybrany > 0)
					{
						wybrany--;
					}
					else if ((keyInfo.Key == ConsoleKey.DownArrow && wybrany == elementy.Length - 1) || keyInfo.Key == ConsoleKey.Home)
					{
						wybrany = 0;
					}
					else if (keyInfo.Key == ConsoleKey.DownArrow)
					{
						wybrany++;
					}
					else if (keyInfo.Key == ConsoleKey.Escape)
					{
						wybrany = -1;
					}

				} while (keyInfo.Key != ConsoleKey.Enter && keyInfo.Key != ConsoleKey.Escape);
			}
			Console.ResetColor();
			return wybrany;
		}

		public int Wyswietl(int wiersz)
		{
			//-1 - kod wyjścia
			if (wiersz == -1) return -1;
			int wybrany = 0;
			if (elementy != null)
			{
				ConsoleKeyInfo keyInfo;
				Console.BackgroundColor = ConsoleColor.DarkBlue;

				do
				{
					for (int i = 0; i < elementy.Length; i++)
					{
						if (i == wybrany)
						{
							Console.BackgroundColor = ConsoleColor.Blue;
						}
						else
						{
							Console.BackgroundColor = ConsoleColor.DarkBlue;
						}
						Console.SetCursorPosition(25, wiersz + i);
						Console.WriteLine(elementy[i].PadRight(najdluzszyElement + 2));
					}


					keyInfo = Console.ReadKey();

					if ((keyInfo.Key == ConsoleKey.UpArrow && wybrany == 0) || keyInfo.Key == ConsoleKey.End)
					{
						wybrany = elementy.Length - 1;
					}
					else if (keyInfo.Key == ConsoleKey.UpArrow && wybrany > 0)
					{
						wybrany--;
					}
					else if ((keyInfo.Key == ConsoleKey.DownArrow && wybrany == elementy.Length - 1) || keyInfo.Key == ConsoleKey.Home)
					{
						wybrany = 0;
					}
					else if (keyInfo.Key == ConsoleKey.DownArrow)
					{
						wybrany++;
					}
					else if (keyInfo.Key == ConsoleKey.Escape)
					{
						wybrany = -1;
					}

				} while (keyInfo.Key != ConsoleKey.Enter && keyInfo.Key != ConsoleKey.Escape);
			}
			else
			{
				Console.Clear();
				Console.WriteLine("Brak pozycji do wyświetleia!");
				Console.ReadKey();
			}
			Console.ResetColor();
			return wybrany;
		}
		/*
				public bool[] Zaznacz(bool[] wybraneInput)
				{
					bool[] wybrane;

					if (wybraneInput == null)
					{
						wybrane = new bool[elementy.Length];
					}
					else
					{
						wybrane = wybraneInput;
					}
					return Zaznacz();

				}*/
		public bool[] Zaznacz()
		{
			bool[] wybrane = new bool[elementy.Length];

			int wybrany = 0;
			if (elementy != null)
			{
				ConsoleKeyInfo keyInfo;
				Console.BackgroundColor = ConsoleColor.DarkBlue;

				do
				{


					Console.SetCursorPosition(0, 0);
					for (int i = 0; i < elementy.Length; i++)
					{
						if (wybrane[i])
						{
							Console.BackgroundColor = ConsoleColor.Green;
						}
						else if (i == wybrany)
						{
							Console.BackgroundColor = ConsoleColor.Blue;
						}
						else
						{
							Console.BackgroundColor = ConsoleColor.DarkBlue;
						}
						Console.WriteLine(elementy[i].PadRight(najdluzszyElement + 2));
					}


					keyInfo = Console.ReadKey();

					if ((keyInfo.Key == ConsoleKey.UpArrow && wybrany == 0) || keyInfo.Key == ConsoleKey.End)
					{
						wybrany = elementy.Length - 1;
					}
					else if (keyInfo.Key == ConsoleKey.UpArrow && wybrany > 0)
					{
						wybrany--;
					}
					else if ((keyInfo.Key == ConsoleKey.DownArrow && wybrany == elementy.Length - 1) || keyInfo.Key == ConsoleKey.Home)
					{
						wybrany = 0;
					}
					else if (keyInfo.Key == ConsoleKey.DownArrow)
					{
						wybrany++;
					}
					if (keyInfo.Key != ConsoleKey.Enter)
					{
						wybrane[wybrany] = !wybrane[wybrany];
					}
					//if (keyInfo.Key != ConsoleKey.K)
					//               {

					//               }
					else if (keyInfo.Key == ConsoleKey.Escape)
					{
						wybrany = -1;
					}

				} while (keyInfo.Key != ConsoleKey.K && keyInfo.Key != ConsoleKey.Escape);
			}
			Console.ResetColor();

			return wybrane;
		}

	}
}
