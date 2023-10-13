using System;

namespace Mod_5_4_Dom_z_
{

    public class MethodCaller
    {
        // Создаем метод Generate Exception и обрабатываем любое вызванное им исключение.
        public void CallGen()
        {
            try
            {
                GenerateEx();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение найдено: {ex.Message}");
            }
        }

        // Генерируем исключение и выбрасываем его.
        private void GenerateEx()
        {
            throw new Exception("Пиво, создано в GenerateEx");
        }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            var methodCaller = new MethodCaller();
            methodCaller.CallGen();
        }
    }
}