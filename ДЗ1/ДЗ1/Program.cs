using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Чабаров
namespace ДЗ1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            /* Задание номер 1
            Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            а) используя склеивание;
            б) используя форматированный вывод;
            в) используя вывод со знаком $.
            */
            Console.WriteLine("Здравствуйте, введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Очень приятно, " + name + "," + " какая у тебя фамилия?");
            string surname = Console.ReadLine();
            Console.WriteLine("Сколько Вам лет?");
            string age = Console.ReadLine();
            Console.WriteLine("Какой у Вас рост?");
            string height = Console.ReadLine();
            Console.WriteLine("Какой у Вас вес?");
            string weight = Console.ReadLine();
            Console.WriteLine($"Ваши данные: {name} {surname}, {age}, {height}см, {weight}кг");
            Console.ReadLine();
            #endregion
            #region
            /* Задание номер 2
               Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
            */
            double m, h, i;
            
                Console.WriteLine("Сейчас рассчитаем индекс массы вашего тела, какой у Вас вес в кг?");
                m = double.Parse(Console.ReadLine());
                Console.WriteLine("Какой у Вас рост в метрах?");
                h = double.Parse(Console.ReadLine());
                i = m / (h * h);
                Console.WriteLine("Ваш индекс массы тела - " + i);
                Console.ReadLine();
            #endregion
            #region
            /* Задание номер 3
               а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            */
            Console.WriteLine("Ведите координаты первой точки x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите координаты первой точки y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите координаты второй точки x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите координаты второй точки y2:");
            double y2 = double.Parse(Console.ReadLine());
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние между точками {0:F2} ", r);
            Console.ReadLine();
            #endregion
            #region

            /* Задание номер 4
               Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
               а) с использованием третьей переменной;
               б) *без использования третьей переменной.
            */
            // С третей переменной

            Console.WriteLine("Ведите значения первой переменной:");
            int variable = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведите значения второй переменной:");
            int variable2 = int.Parse(Console.ReadLine());
            Console.WriteLine("первая переменная " + variable);
            Console.WriteLine("вторая переменная " + variable2);
            int result = variable;
            variable = variable2;
            variable2 = result;
            Console.WriteLine("первая переменная после обмена " + variable);
            Console.WriteLine("вторая переменная после обмена " + variable2);

            // Без третей переменной

            variable = variable + variable2;
            variable2 = variable2 - variable;
            variable2 = -variable2;
            variable = variable - variable2;
            Console.WriteLine("первая переменная после второго обмена " + variable);
            Console.WriteLine("вторая переменная после второго обмена " + variable2);
            Console.ReadLine();
            #endregion
            /* Задание номер 5
               а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
               б) Сделать задание, только вывод организовать в центре экрана.
               в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
            */

            Console.WriteLine("Добрый день. Как вас зовут?");
            string imya = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string familiya = Console.ReadLine();
            Console.WriteLine("И в каком городе вы живете? ");
            string gorod = Console.ReadLine();

            Console.SetCursorPosition(100, 100);
            Console.WriteLine(imya);
            Console.SetCursorPosition(100, 100);
            Console.WriteLine(familiya);
            Console.SetCursorPosition(100, 100);
            Console.WriteLine(gorod);
            Console.ReadLine();
        }
    }
}
