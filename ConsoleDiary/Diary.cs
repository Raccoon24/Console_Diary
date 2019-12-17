using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDiary
{
   
    
        // структура инициализации данных
        public struct Diary
        {
            //создание номера
            public int Number { get; set; }
            //создание Имя
            public string Name { get; set; }
            //создание Даты и Время
            public DateTime ParsedDate { get; set; }
            //создание Место
            public string Place { get; set; }
            //создание Действие
            public string Action { get; set; }

            //Метод добавления данных
            public List<Diary> AddingData(List<Diary> myList)
            {
                Console.WriteLine(" - цифра нажатая вами (Добавление)");
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

                return myList;

            }
            //Метод вывода
            public List<Diary> ShowData(List<Diary> myList)
            {
                foreach (Diary d in myList)
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("{0} - {1} - {2} - {3} - {4}", d.Number, d.Name, d.ParsedDate, d.Place, d.Action);
                    Console.WriteLine("-----------------------------------------");
                }
                return myList;
            }
            //Метод удаления данных
            public List<Diary> RemoveData(List<Diary> myList)
            {
                Console.WriteLine(" - цифра нажатая вами (Удаление) ");
                Console.WriteLine("Введите номер строки для удаления");

                int r = Convert.ToInt32(Console.ReadLine());

                myList.RemoveAt(r);

                return myList;
            }
            //Метод редактирования данных
            public List<Diary> EditingData(List<Diary> myList)
            {
                Console.WriteLine(" - цифра нажатая вами (Редактирование)");
                Console.WriteLine("Введите индекс строки");

                int t = Convert.ToInt32(Console.ReadLine());
                var el = myList[t];
                myList.Remove(el);
                Console.WriteLine("Введите Номер");
                el.Number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите Имя");
                el.Name = Console.ReadLine();
                Console.WriteLine("Введите Дату и Время");
                el.ParsedDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Введите Место");
                el.Place = Console.ReadLine();
                Console.WriteLine("Введите Действие");
                el.Action = Console.ReadLine();

                myList.Add(el);

                return myList;
            }
            //Метод сортировки данных по номеру
            public List<Diary> SortDataNumber(List<Diary> myList)
            {
                myList.Sort((a, b) => a.Number.CompareTo(b.Number));

                return myList;
            }
            //Метод сортировки данных по имени
            public List<Diary> SortDataName(List<Diary> myList)
            {
                myList.Sort((a, b) => a.Name.CompareTo(b.Name));

                return myList;
            }
            //Метод сортировки данных по дате и времени
            public List<Diary> SortDataDateTime(List<Diary> myList)
            {
                myList.Sort((a, b) => a.ParsedDate.CompareTo(b.ParsedDate));

                return myList;
            }
            //Метод сортировки данных по месту
            public List<Diary> SortDataPlace(List<Diary> myList)
            {
                myList.Sort((a, b) => a.Place.CompareTo(b.Place));

                return myList;
            }
            //Метод сортировки данных по действию
            public List<Diary> SortDataAction(List<Diary> myList)
            {
                myList.Sort((a, b) => a.Action.CompareTo(b.Action));

                return myList;
            }
            //Метод записи данных в файл
            public List<Diary> DataEntryFile(List<Diary> myList)
            {
                Console.WriteLine("Сохранено");
                using (var sw = new StreamWriter("C:\\Test.txt"))
                {
                    foreach (var elem in myList)
                    {
                        sw.WriteLine();
                        sw.WriteLine(elem.Number);
                        sw.WriteLine(elem.Name);
                        sw.WriteLine(elem.ParsedDate);
                        sw.WriteLine(elem.Place);
                        sw.WriteLine(elem.Action);
                    }
                }
                return myList;
            }
            //Метод показать данных из файла
            public List<Diary> DataShowFile(List<Diary> myList)
            {
                Console.WriteLine(" - цифра нажатая вами (Показать данные из файла) ");
                string sww = @"C:\\Test.txt";
                try
                {
                    using (StreamReader sr = new StreamReader(sww))
                    {
                        Console.WriteLine(sr.ReadToEnd());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return myList;
            }
            //Метод очистки данных
            public List<Diary> ClearData(List<Diary> myList)
            {
                Console.WriteLine(" - буква нажатая вами (Очистить) ");
                myList.Clear();
                Console.WriteLine("Список очищен");

                return myList;
            }
            //Метод вывода,если нажато что то не то
            public void ClickError()
            {
                Console.WriteLine("нажато что то не то");
            }
            //Метод вывода интерфейса
            public void Interface()
            {
                Console.WriteLine("Введите 1 чтобы добавить строку элементов");
                Console.WriteLine("Введите 2 чтобы удалить строку элементов");
                Console.WriteLine("Введите 3 чтобы редактировать строку элементов");
                Console.WriteLine("Введите 4 чтобы сортировать по номеру");
                Console.WriteLine("Введите 5 чтобы сортировать по имени");
                Console.WriteLine("Введите 6 чтобы сортировать по дате и времени");
                Console.WriteLine("Введите 7 чтобы сортировать по месту");
                Console.WriteLine("Введите 8 чтобы сортировать по действию");
                Console.WriteLine("Введите 9 чтобы записать данные в файл");
                Console.WriteLine("Введите 0 чтобы показать данные из файла");
                Console.WriteLine("Введите С чтобы очистить данные");
                Console.WriteLine("Введите P чтобы отобразить данные");
                Console.WriteLine("Введите X чтобы выйти");
            }

        }
}
