using System;
using System.Data;

namespace ежедневник
{
    internal class Program
    {
        public static void Main()
        {
            arrowt(0);
        }
        public static void arrowt(int uwu)
        {
            
            int position = 1;
            ConsoleKeyInfo key = Console.ReadKey();

            DateTime date = DateTime.Now;

            while (key.Key != ConsoleKey.Escape)
            {
               
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;

                }
                
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    uwu--;
                  date = date.AddDays(-1);
                   
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    uwu++;
                   date = date.AddDays(1);
                    
                }
                Console.Clear();
               
                switch (uwu)
                {
                    case 0:
                        {
                            date = DateTime.Now;
                            Console.WriteLine("Выбрана дата: " + date);
                            Menu();
                            if (key.Key == ConsoleKey.Enter)
                            {

                                if (position == 1)
                                {
                                    Console.Clear();
                                    subMenu("  Прийти на работу", "  Кого-то чему-то научить", 0);

                                }
                                else if (position == 2)
                                {
                                    Console.Clear();
                                    subMenu("  Выпить кофе", "  Выпить кофе и посмотреть телевизор", 0);

                                }
                            }
                        }
                        break;
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Выбрана дата: " + date);
                            menu3();

                            if (key.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                if (position == 1)
                                {
                                    subMenu("   Применить дзанпакто", "Уничтожить группу пустых, при этом не умереть", +1);

                                }
                                else if(position == 2)
                                {
                                    subMenu("  Посмотреть новые серии аниме 'Блич' ", "   Прийти домой, заварить чай и посмотреть аниме'Блич'", +1);
                                }
                            }
                        }
                        break;
                        case -1:
                        {
                            Console.Clear();
                            Console.WriteLine("Выбрана дата: " + date);
                            menu2();
                            if (key.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                if (position == 1)
                                {
                                    subMenu("  Приготовить торт", "Взбить сливки, сделать бисквит", -1);

                                }

                            }
                        }
                        break;
                    default:
                        {
                            
                            Console.WriteLine("Выбрана дата: " + date);
                        }
                        break;
                   
                }

                


                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key = Console.ReadKey();
            }
           
        }

        public static void Menu()
        {
            Top zametka1 = new Top();

            zametka1.Name = "  Прийти на работу";
            zametka1.Description = "Кого-то чему-то научить";

            Top zametka2 = new Top();

            zametka2.Name = "  Выпить кофе";
            zametka2.Description = "Выпить кофе и посмотреть телевизор";
            List<Top> dateTimes = new List<Top>()
           {
               zametka1,zametka2
               };

            foreach (var date in dateTimes)
            {
                Console.WriteLine(date.Name);
            }
        }
        public static void menu2()
        {
            Top zametka3 = new Top();

            zametka3.Name = "  Приготовить торт";
            zametka3.Description = "Взбить сливки, сделать бисквит";
            List<Top> dateTimes = new List<Top>()
           {
               zametka3
               };

            foreach (var date in dateTimes)
            {
                Console.WriteLine(date.Name);
            }

        }
        public static void menu3()
        {
            Top zametka4 = new Top();

            zametka4.Name = "  Применить дзанпакто";
            zametka4.Description = " Уничтожить группу пустых, при этом не умереть";

            Top zametka5 = new Top();

            zametka5.Name = "  Посмотреть новые серии аниме 'Блич'";
            zametka5.Description = " Прийти домой, заварить чай и посмотреть аниме'Блич'";
            List<Top> dateTimes = new List<Top>()
           {
               zametka4,zametka5
               };

            foreach (var date in dateTimes)
            {
                Console.WriteLine(date.Name);
            }

        }
        public static void subMenu(string name, string description, int trt)
        {

            Top zametka1 = new Top();
            DateTime DayMonthYear = DateTime.Now;
            zametka1.Name = name;

            zametka1.Description = description;
            List<Top> lazy = new List<Top>()
            {
                zametka1
            };
            foreach (var Date in lazy)
            {
                Console.WriteLine(Date.Name);
                Console.WriteLine("------------------");
                Console.WriteLine(Date.Description);
                Console.WriteLine(DayMonthYear.AddDays(trt));

            }
        }
        
       
       
        
      

    }
}

 
 