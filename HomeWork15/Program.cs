using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork15
{
    class Program
    {
        // Разработка интерфейса ISeries для генерации ряда чисел
        static void Main(string[] args)
        {
            Console.WriteLine("Для вывода значений арифметической прогрессии введите следующие данные:");
            Console.Write("Значение первого члена прогресии N1: ");
            int arithmN1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Значение N2 для определения последнего члена прогресии: ");
            int arithmN2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Значение разности прогресии D: ");
            int arithmDif = Convert.ToInt32(Console.ReadLine());
            ArithmProgression ob1 = new ArithmProgression(arithmDif, arithmN1);

            #region
            Console.WriteLine("Результат арифметической прогрессии:");
            for (int i = arithmN1; i < arithmN2; i = i + arithmDif)
            {
                ob1.SetStart(i);
                Console.WriteLine(ob1.GetNext());
            }

            Console.WriteLine("Результат арифметической прогрессии после сброса результата, начиная с первого члена:");
            for (int i = arithmN1; i < arithmN2; i = i + arithmDif)
            {
                ob1.Reset();
                ob1.SetStart(i);
                Console.WriteLine(ob1.GetNext());
            }
            Console.WriteLine();
            #endregion

            #region
            Console.WriteLine("Для вывода результатов значений геометрической прогрессии введите следующие данные:");
            Console.Write("Значение первого члена прогресии N1: ");
            int geomN1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Значение N2 для определения последнего члена прогресии: ");
            int geomN2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Значение знаменателя прогресии Q: ");
            int geomDenom = Convert.ToInt32(Console.ReadLine());
            GeomProgression ob2 = new GeomProgression(geomDenom, geomN1);

            Console.WriteLine("Результат геометрической прогрессии:");
            for (int i = arithmN1; i < arithmN2; i *= geomDenom)
            {
                ob2.SetStart(i);
                Console.WriteLine(ob2.GetNext());
            }

            Console.WriteLine("Результат геометрической прогрессии после сброса результата, начиная с первого члена:");
            for (int i = arithmN1; i < arithmN2; i *= geomDenom)
            {
                ob2.Reset();
                ob2.SetStart(i);
                Console.WriteLine(ob2.GetNext());
            }
            #endregion
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
    public class ArithmProgression : ISeries
    {
        int start;
        int resetVal;
        int dif;

        public ArithmProgression(int dif, int resetVal)
        {
            this.dif = dif;
            this.resetVal = resetVal;
        }
        public void SetStart(int x)
        {
            start = x;
        }
        public int GetNext()
        {
            int next = start + dif;
            return next;
        }
        public void Reset()
        {
            start = resetVal;
        }
    }
    public class GeomProgression : ISeries
    {
        int start;
        int resetVal;
        int denom;

        public GeomProgression(int denom, int resetVal)
        {
            this.denom = denom;
            this.resetVal = resetVal;
        }
        public void SetStart(int x)
        {
            start = x;
        }
        public int GetNext()
        {
            int next = start * denom;
            return next;

        }
        public void Reset()
        {
            start = resetVal;
        }
    }
}
