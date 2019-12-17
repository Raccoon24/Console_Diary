using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            // создание объекта
            List<Diary> myList = new List<Diary>();
            Console.WriteLine("-- Введите пробную первую запись для активации блокнота --");
            Console.WriteLine("Введите Номер");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Имя");
            string m = Console.ReadLine();
            Console.WriteLine("Введите Дату и Время");
            DateTime l = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите Место");
            string p = Console.ReadLine();
            Console.WriteLine("Введите Действие");
            string f = Console.ReadLine();

            myList.Add(new Diary() { Number = n, Name = m, ParsedDate = l, Place = p, Action = f });

            myList[0].ShowData(myList);

            //бесконечный цикл
            while (true)
            {
                myList[0].Interface();

                //ввод данных
                char key = Console.ReadKey().KeyChar;

                //ввод данных пользователем
                switch (key)
                {
                    case '1':
                        myList[0].AddingData(myList);
                        myList[0].ShowData(myList);

                        break;
                    case '2':
                        myList[0].RemoveData(myList);
                        myList[0].ShowData(myList);
                        break;
                    case '3':
                        myList[0].EditingData(myList);
                        myList[0].ShowData(myList);
                        break;
                    case '4':
                        myList[0].SortDataNumber(myList);
                        myList[0].ShowData(myList);
                        break;
                    case '5':
                        myList[0].SortDataName(myList);
                        myList[0].ShowData(myList);
                        break;
                    case '6':
                        myList[0].SortDataDateTime(myList);
                        myList[0].ShowData(myList);
                        break;
                    case '7':
                        myList[0].SortDataPlace(myList);
                        myList[0].ShowData(myList);
                        break;
                    case '8':
                        myList[0].SortDataAction(myList);
                        myList[0].ShowData(myList);
                        break;
                    case '9':
                        myList[0].DataEntryFile(myList);
                        myList[0].ShowData(myList);
                        break;
                    case '0':
                        myList[0].DataShowFile(myList);
                        myList[0].ShowData(myList);
                        break;
                    case 'C':
                        myList[0].ClearData(myList);
                        myList[0].ShowData(myList);
                        break;
                    case 'P':
                        myList[0].ShowData(myList);
                        break;
                    case 'X':
                        return;
                    default:
                        myList[0].ClickError();
                        break;
                }
            }
        }
    }
}
