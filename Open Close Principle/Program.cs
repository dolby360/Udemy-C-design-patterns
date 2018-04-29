using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy;
using static System.Console;

namespace Udemy
{
    public class Programm{
        public static void Main(string[] args) {
            var p1 = new Phone(5.5, Brand.LG, Processor.A9);
            var p2 = new Phone(5, Brand.Samsund, Processor.Exynos);
            var p3 = new Phone(7.3, Brand.Xiaomi, Processor.Qualcomm);
            var p4 = new Phone(5.5, Brand.Xiaomi, Processor.A9);
            var p5 = new Phone(5, Brand.LG, Processor.Exynos);
            var p6 = new Phone(7.3, Brand.Samsund, Processor.Qualcomm);

            Phone[] myPhones = { p1, p2, p3, p4, p5, p6 };
            bestFilter bf = new bestFilter();

            WriteLine("Brand:");
            foreach (var i in bf.Filter(myPhones,new brandSpecification(Brand.Xiaomi))) {
                WriteLine($" - {i.proc} - {i.size} - {i.brand}");
            }

            WriteLine("Processor:");
            foreach (var i in bf.Filter(myPhones, new processorSpecification(Processor.A9))) {
                WriteLine($"Brand - {i.brand}  Processor - {i.proc} size - {i.size}");
            }

            WriteLine("Brand and Processor:");
            foreach (var i in bf.Filter(myPhones, 
                new AndSpecification<Phone>
                (new processorSpecification(Processor.A9),
                new brandSpecification(Brand.LG)))) {
                WriteLine($"Brand - {i.brand}  Processor - {i.proc} size - {i.size}");
            }
            ReadLine();   
        }
    }
}
