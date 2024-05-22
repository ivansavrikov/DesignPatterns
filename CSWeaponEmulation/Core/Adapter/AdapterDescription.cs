/* Адаптер - это структурный паттерн проектирования, который позволяет объектам с несовместимыми интерфейсами взаимодействия работать вместе.
 * 
 * Интерфейс взаимодействия - набор публичнов членов класса (методов, свойств) с которыми будет рабоать клиентский код
 * interface (C#) - объект для определения интерфейса взаимодействия, который должен быть реализован в наследниках
 * 
 * Клиетский код - Код программы, который использует функциональность реализованных классов/объектов
 * 
 * Потребность данного паттерна возникает тогда, когда нам нужно совместить два объекта/класса с несовместимыми интерфейсами взаимодействия,
 * 
 * Например:
 * Наша программа поддерживается многими программистами уже несколько лет.
 * Часть клиентского кода нашей программы работает с оружием, у которого есть прицел через интерфейс IScopable (AWP).
 * Нам необходимо сделать так, чтобы оружие LegacyAug, реализовывало интерфейс IScopable, чтобы клиентский код нашей программы работал с ним через данный интерфейс.
 * У оружия LegacyAug уже есть метод отвечающий за оптическое прицеливание, но он не соответсвует сигнатуре метода Scope в интерфейсе IScopable.
 * 
 * Класс LegacyAug изменять нельзя, так как большая часть нашей программы уже использует его определенным образом, если поменять что-то в нем, то вся программа может сломаться.
 * Также может не быть доступа к исходному коду данного класса для его модификации.
 *
 * Нам необходимо использовать функциональность метода LegacyAug.OpenScope() класса  через интерфейс IScopable с методом Scope().
 * 
 * РЕШЕНИЕ смотреть в классе Aug.cs
 * 
 * Также потребность данного паттерна может возникнуть, когда нам необходимо реализовать класс с определенным интерфейсом,
 * и у нас есть другой класс, часть функциональности которого можно использовать пример ниже:
*/

using System;

namespace example
{
    class AdaptableClass
    {
        public int GetIntFromString(string numberWord)
        {
            if (numberWord.ToLower() == "один")
            {
                return 1;
            }

            //может быть много полезной нам функциональности, которую нам не хочется писать самим)
            
            return default;
        }

        public bool CalcTruth(string quetion)
        {
            // вычисление
            bool result = false;
            return result;
        }
    }

    interface INumberWordPrinter
    {
        void PrintWordFromNumber(int number);
        void PrintNumberFromWord(string numberWord);
    }

    //Реализация через экземпляр класса, в данном случае наследоваться от AdaptableClass неправильно
    class AdapterClass : INumberWordPrinter
    {
        private static AdaptableClass adaptableClass = new AdaptableClass();

        public void PrintNumberFromWord(string numberWord)
        {
            int number = adaptableClass.GetIntFromString(numberWord); //Заимствуем нужную нам функциональность
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(number);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrintWordFromNumber(int number)
        {
            if (number == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ОДИН");
                Console.ForegroundColor = ConsoleColor.White;
            }

            // и так далее
        }
    }
}