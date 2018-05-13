using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy;
using static System.Console;

namespace Udemy {
    public interface Imuse {
        void onClick();
    }
    public interface clickable:Imuse {
        void click();
    }
    public interface tuchable:Imuse {
        void tuch();
    }
    public interface multiMuse : clickable, tuchable {
    }

    public class appleMuse : multiMuse{
        private string myClickSound;
        public appleMuse() {
            myClickSound = "click";
        }
        public void click(){
            WriteLine($"My click sound = {myClickSound}");
        }
        public void tuch(){
            WriteLine("And I also tuchable");
        }
        public void onClick(){
            click();
            tuch();
        }

    }
    public class stopidMuse : clickable{
        private string clickSound;
        public stopidMuse() {
            clickSound = "nick";
        }
        public void click(){
            WriteLine($"My click sound = {clickSound}");
        }
        public void onClick(){
            click();
        }
    }

    public class Programm{
        public static void Main(string[] args){
            List<Imuse> myList = new List<Imuse>();
            myList.Add(new appleMuse());
            myList.Add(new stopidMuse());
            foreach (var i in myList) {
                i.onClick();
                WriteLine();
            }
            ReadLine();
        }        
    }
}
