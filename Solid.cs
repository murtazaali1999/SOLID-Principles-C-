using System;
using static System.Math;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Vertebrate {
        private string name;
        private string type; //Dog/Cat/Lion etc
        private int age;
        private double height;

        public void Vertebrate(string name,string type,int age,double height){
        setName(name);
        setType(type);
        setAge(age);
        setHeight(height);
        }

        public string Name {
            set{name = value;}
            get{return name;}
        }

        public string Type {
            set{type = value;}
            get{return type;}
        }

        public int Age {
            set{age = value;}
            get{return age;}
        }

        public double Height {
            set{height = value;}
            get{return height;}
        }

    }

    class InVertebrate {
        private string name;
        private string type; //JellyFish/WaterBottle etc
        private int age;
        private double height;

        public void InVertebrate(string name,string type,int age,double height){
        setName(name);
        setType(type);
        setAge(age);
        setHeight(height);
        }

        public string Name {
            set{name = value;}
            get{return name;}
        }

        public string Type {
            set{type = value;}
            get{return type;}
        }

        public int Age {
            set{age = value;}
            get{return age;}
        }

        public double Height {
            set{height = value;}
            get{return height;}
        }

    }

    class Attack : Vertebrate : InVertebrate{
       public:
    
       public void attack(){
        Console.WriteLine("Attack");
       }

    }

    /*
    Interface

    class one implementing interface
    class two implementing interface


    Character{
       attack
       defend
       heal
       escape 
    }

    */

    interface Character{
        public void attack();
        public void defend();
        public void heal();
        public void escape();
    }

    class Hero:Character{
        //short-hand of get-set
        public int Life{
            get;
            set;
        }
        public int Name{
            get;
            set;
        }
        public int Age{
            get;
            set;
        }
        public int AttackPoints{
            get;
            set;
        }
        public int HealPoints{
            get;
            set;
        }
        public int UserName{
            get;
            set;
        }

        public void attack(){
            //code here
        }
        public void defend(){
            //code here
        }
        public void heal(){
            //code here
        }
        public void escape(){
            //code here
        }

    }


    class Villan:Character{
        //short-hand of get-set
        public int Life{
            get;
            set;
        }
        public int Name{
            get;
            set;
        }
        public int Age{
            get;
            set;
        }
        public int AttackPoints{
            get;
            set;
        }
        public int HealPoints{
            get;
            set;
        }

        public void attack(){
            //code here
        }
        public void defend(){
            //code here
        }
        public void heal(){
            //code here
        }
        public void escape(){
            //code here
        }

    }





}