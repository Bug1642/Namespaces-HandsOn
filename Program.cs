using System;
using Earth = myNamespace;
using World = uniqueNamespace;
using text;

namespace Exercise {
    }
    class Program{
        static void Main(string [] args ){
            Earth.AnotherProgram ap = new Earth.AnotherProgram();
            World.AnotherProgram2 ap2 =new World.AnotherProgram2();
            AnotherProgram3 ap3 = new AnotherProgram3();
            ap.PrintText();
            ap2.PrintTextu();
            ap3.PrintTexta();
        }
    }

