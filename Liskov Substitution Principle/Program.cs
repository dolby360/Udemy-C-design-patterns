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
    public class Dragon{
        public virtual bool fireSpit { get; set; }
        public string myName { get; set; }
        public Dragon(string name) {
            fireSpit = true;
            myName = name;
        }
        public override string ToString()
        {
            return $"{myName} Drag";
        }
    }
    public class lizard : Dragon{
        public lizard(string name) : base(name)
        {
        }

        public override bool fireSpit {
            //Probably not the best idea....
            set { base.fireSpit = false; }
        }
        public override string ToString()
        {
            return $"{base.myName} - lis";
        }
    }

    //Single Responsibility
    public class Attack{
        public void DragonAttack(Dragon d) {
            if (d.fireSpit) {
                WriteLine($"{d} - Fire!!!!!!!!!!!!!!!!");
            }
        }
    }
    public class Programm{
        public static void Main(string[] args) {
            Dragon myLiz1 = new lizard("1");
            Dragon myLiz2 = new lizard("2");
            Dragon myLiz3 = new lizard("3");
            Dragon real1 = new Dragon("4");
            Dragon real2 = new Dragon("5");
            Dragon real3 = new Dragon("6");
            List<Dragon> creatures = new List<Dragon>();
            creatures.Add(myLiz1);
            creatures.Add(myLiz2);
            creatures.Add(myLiz3);
            creatures.Add(real1);
            creatures.Add(real2);
            creatures.Add(real3);
            Attack fireAttack = new Attack();
            foreach (var i in creatures) {
                fireAttack.DragonAttack(i);
            }
            ReadLine();
        }
        
    }
}
