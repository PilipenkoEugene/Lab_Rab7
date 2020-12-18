using System;
using System.Linq;

namespace BBB
{
    class Sphere
    {
        private double r;

        private Sphere() {}
        
        public Sphere(double rr) {
        	r = rr;
        }
        
        public double getSquare() {
        	return Math.PI * 4 * r * r;
        }

        public double getValue() { 
        	return ((double) 4 / (double) 3) * Math.PI * Math.Pow(r, 3);
        }
        
        public double getD() {
        	return r * 2;
        }

        public void Info() {
            String str = "Данные заданной сфере";
            Console.WriteLine(str);
            Console.WriteLine(string.Format("r = {0:0.00}", r));
            Console.WriteLine(string.Format("d = {0:0.00}", getD()));
            Console.WriteLine(string.Format("Vsp = {0:0.00}", getValue()));
            Console.WriteLine(string.Format("Ssp = {0:0.00}", getSquare()));
        }
        
        public void Info(ConsoleColor fg, ConsoleColor bgc) {
        	Console.ForegroundColor = fg;
        	Console.BackgroundColor = bgc;
        	Console.Clear();
        	Info();
        }

        public void Load() {
            r = Convert.ToDouble(Console.ReadLine());
        }
        
        public static Sphere createSphereFromFile(){
        	double rFile = Convert.ToDouble(Console.ReadLine());
        	return new Sphere(rFile);
        }
    }
}