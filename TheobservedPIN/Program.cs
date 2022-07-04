using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObservedPIN
{
    //    Alright, detective, one of our colleagues successfully observed our target person, Robby the robber.We followed him to a secret warehouse, where we assume to find all the stolen stuff.The door to this warehouse is secured by an electronic combination lock. Unfortunately our spy isn't sure about the PIN he saw, when Robby entered it.


    //The keypad has the following layout:

    //┌───┬───┬───┐
    //│ 1 │ 2 │ 3 │
    //├───┼───┼───┤
    //│ 4 │ 5 │ 6 │
    //├───┼───┼───┤
    //│ 7 │ 8 │ 9 │
    //└───┼───┼───┘
    //    │ 0 │
    //    └───┘
    //He noted the PIN 1357, but he also said, it is possible that each of the digits he saw could actually be another adjacent digit (horizontally or vertically, but not diagonally). E.g. instead of the 1 it could also be the 2 or 4. And instead of the 5 it could also be the 2, 4, 6 or 8.

    //He also mentioned, he knows this kind of locks. You can enter an unlimited amount of wrong PINs, they never finally lock the system or sound the alarm.
    //That's why we can try out all possible (*) variations.

    //* possible in sense of: the observed PIN itself and all variations considering the adjacent digits

    //Can you help us to find all those variations? It would be nice to have a function, that returns an array (or a list in Java/Kotlin and C#) of all variations for an observed PIN with a length of 1 to 8 digits. We could name the function getPINs (get_pins in python, GetPINs in C#). But please note that all PINs, the observed one and also the results, must be strings, because of potentially leading '0's. We already prepared some test cases for you.

    //Detective, we are counting on you!

    //For C# user: Do not use Mono. Mono is too slower when run your code.

    // Итак, детектив, один из наших коллег успешно обнаружил нашу цель, грабителя Робби.
    // Мы проследили за ним до секретного склада, где предполагаем найти все украденные вещи. Дверь на этот склад защищена электронным кодовым замком. .
    // К сожалению, наш шпион не уверен в ПИН-коде, который он видел, когда Робби ввел его.


    // Клавиатура имеет следующую раскладку:

    //┌───┬───┬───┐
    //│ 1 │ 2 │ 3 │
    //├───┼───┼───┤
    //│ 4 │ 5 │ 6 │
    //├───┼───┼───┤
    //│ 7 │ 8 │ 9 │
    //└───┼───┼───┘
    // │ 0 │
    // └───┘
    // Он отметил PIN-код 1357, но также сказал, что возможно, что каждая из увиденных им цифр на самом деле может быть другой соседней цифрой
    // (по горизонтали или вертикали, но не по диагонали). Например. вместо 1 также может быть 2 или 4. А вместо 5 также может быть 2, 4, 6 или 8.

    // Он также упомянул, что знает такие блокировки.
    // Вы можете ввести неограниченное количество неправильных PIN-кодов, они никогда не заблокируют систему окончательно и не подадут сигнал тревоги.
    // Вот почему мы можем попробовать все возможные (*) варианты.

    //* возможно в смысле: самого наблюдаемого PIN-кода и всех вариаций с учетом соседних цифр

    //Можете ли вы помочь нам найти все эти варианты? Было бы неплохо иметь функцию, которая возвращает массив (или список в Java/Kotlin и C#)
    //всех вариантов наблюдаемого PIN-кода длиной от 1 до 8 цифр. Мы могли бы назвать функцию getPINs (get_pins в python, GetPINs в C#).
    //Но обратите внимание, что все PIN-коды, как наблюдаемые, так и результаты, должны быть строками из-за потенциально ведущих нулей.
    //Мы уже подготовили для вас несколько тестовых случаев.

    //Детектив, мы рассчитываем на вас!

    //Для пользователя C#: не используйте Mono. Моно слишком медленнее при запуске вашего кода.
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> pins = new List<string>();
            Kata.GetPINs("1");
            Console.WriteLine(Kata.GetPINs("1"));
            Console.ReadLine();
        }

    }
    public class Kata
    {

        public static List<IEnumerable<string>> _numbers = new List<IEnumerable<string>>
    {
        new List<string> {"0", "8"},
        new List<string> {"1", "2", "4"},
        new List<string> {"2", "1", "3", "5"},
        new List<string> {"3", "2", "6"},
        new List<string> {"4", "1", "5", "7"},
        new List<string> {"5", "4", "2", "6", "8"},
        new List<string> {"6", "3", "5", "9"},
        new List<string> {"7", "4", "8"},
        new List<string> {"8", "5", "7", "9", "0"},
        new List<string> {"9", "6", "8"}
    };

        //public static List<string> GetPINs(string observed)
        //{
        //    return observed.Select(x => _numbers[x - '0']).Aggregate((x, y) => x.Join(y, a => 1, b => 1, (A, B) => A + B)).ToList();

        //}

        public static List<string> GetPINs(string observed)
        {
            string[][] pop = new string[10][];
            pop[0] = new string[] { "0", "8" };
            pop[1] = new string[] { "1", "2", "4" };
            pop[2] = new string[] { "1", "2", "3", "5" };
            pop[3] = new string[] { "2", "3", "6" };
            pop[4] = new string[] { "1", "4", "5", "7" };
            pop[5] = new string[] { "2", "4", "5", "6", "8" };
            pop[6] = new string[] { "3", "5", "6", "9" };
            pop[7] = new string[] { "4", "7", "8" };
            pop[8] = new string[] { "0", "5", "8", "7", "9" };
            pop[9] = new string[] { "6", "8", "9" };

            int val = int.Parse(observed[0].ToString());
            var res = pop[val].ToList();

            for (int i = 1; i < observed.Length; i++)
            {
                val = int.Parse(observed[i].ToString());
                var prom = new List<string>();

                for (int x = 0; x < res.Count; x++)
                {
                    string such = res[x];

                    for (int y = 0; y < pop[val].Length; y++)
                        prom.Add(such + pop[val][y]);
                }
                res = prom;
            }
            return res;
        }

    }
}

