using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    class Shop
    {
        private List<Showcase> _showcases = new List<Showcase>();
        private bool _isOpen = true;
        public void Open()
        {
            do
            {
                Menu();
            } while (_isOpen);
        }
        private void Menu()
        {
            
            Console.Write("1. Add showcase\n" +
                                "2. Show showcases\n" +
                                "3. Edit showcase\n" +
                                "4. Delete showcase\n" +
                                "5. Close programm\n");
            ConsoleKeyInfo operation = Console.ReadKey(true);
            switch (operation.Key)
            {
                case ConsoleKey.D1:
                    try
                    {
                        Console.Clear();
                        Console.Write("Print name: ");
                        string nameShowcase = Console.ReadLine();
                        Console.Write("Print capacity: ");
                        uint capacityShowcase = Convert.ToUInt32(Console.ReadLine());
                        if (capacityShowcase < 1)
                            throw new Exception("Capacity < 1");
                        Showcase showcase = new Showcase(nameShowcase, capacityShowcase);
                        _showcases.Add(showcase);
                        Console.Clear();
                        Console.WriteLine("Showcase added\n");
                    }
                    catch
                    {
                        Console.WriteLine("You have entered incorrect data");
                    }          
                    break;
                case ConsoleKey.D2:
                    if(_showcases.Count==0)
                    {
                        Console.Clear();
                        Console.WriteLine("No data\n");
                    }
                    else
                    {
                        for (int i = 0; i < _showcases.Count; i++)
                        {
                            Console.WriteLine($"Id: {_showcases[i].Id}  Name: {_showcases[i].Name}  Capacity: {_showcases[i].Capacity}");
                        }
                    }
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Вы пошли назад");
                    /*
                     * Выберите витрину
                     * Поменять название
                     * Сменить Объём
                     * Добавить товар на витрину
                     * Выйти
                     */
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("Вы двинулись направо");
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("Programm is closed");
                    _isOpen = false;
                    break;
                default:
                    Console.WriteLine("Not found");
                    break;
            }
        }
    }
}
