using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_Box
{
    /// <summary>
    /// Класс Box (коробка), описывающий объект с размерами и объемом
    /// </summary>
    class Box
    {
        // Открытые поля для хранения данных о высоте, ширине, длине
        public float height; // высота
        public float width; // ширина
        public float length; // длина

        /// <summary>
        /// Метод для отображения данных о коробке на экране
        /// </summary>
        public void Show()
        {
            Console.WriteLine("Данные о коробке:");
            Console.WriteLine($" Высота: {height}");
            Console.WriteLine($" Ширина: {width}");
            Console.WriteLine($" Длина: {length}");
        }

        /// <summary>
        /// Метод для расчета объема коробки
        /// </summary>
        /// <returns>Объем коробки</returns>
        public float Volume()
        {
            // Объем = высота * ширина * длина
            return height * width * length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем объект класса Box
            Box myBox = new Box();

            // 2. Задаем значения полям: ширина = 2, высота = 3, длина = 5
            myBox.width = 2;
            myBox.height = 3;
            myBox.length = 5;

            // 3. Выводим на экран данные, хранящиеся в объекте
            myBox.Show();

            Console.WriteLine(); // Пустая строка для разделения вывода

            // 4. Рассчитываем объем коробки и выводим его на экран
            float boxVolume = myBox.Volume();
            Console.WriteLine($"Объем коробки: {boxVolume}");

            // Ожидаем нажатия клавиши, чтобы консоль не закрылась сразу
            Console.ReadKey();
        }
    }
}

