using System;

namespace ทำข้อสอบ ข้อ3
{
    class Program 
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            float filmBackWidth = float.Parse(Console.ReadLine());
            if (filmBackWidth <0)
            {
                Console.WriteLine("Invalid filmBackWidth please input again");
                return;
            }
            defineflenfov();
        }
        static void defineflenfov()
        {
            float flength, fov;
            flength = float.Parse(Console.ReadLine());
            fov = float.Parse(Console.ReadLine());

            if (flength = mode)
            {
                doflength();
            }
            else if(fov =moode)
            {
                dofov();
            }
        }
        static void doflength()
        {
            float flength= float.Parse(Console.ReadLine());
            if(flength>0)
            {
                fovequa();
            }
            else if (flength<0)
            {
                Console.WriteLine("Invalid flength please input again");
                return;
            }
        }
        static void dofov()
        {
            float fov = float.Parse(Console.ReadLine());
            if (fov > 0.1&&fov<6.28)
            {
                flengthequa();
            }
            else if (fov < 0.1&&fov>6.28)
            {
                Console.WriteLine("Invalid fov please input again");
                return;
            }
        }
        static void fovequa()
        {
            fov = 2 * atan(filmBackWidth / 2, flength);
            Console.WriteLine("flength ={0}fov={1}", flength, fov);
        }
        static void flengthequa()
        {
            flength = filmBackWidth/(2*tan(fovequa/2))
            Console.WriteLine("flength ={0}fov={1}", flength, fov);
        }
    }
}
