
using System;
using System.Collections.Generic; //список
namespace Classes
{
    abstract class Student //абстрактний клас
    {
        public Student(string name)
        { //ім'я та порожній стейт
            _name = name;
            _state = "";
        }
        public void Relax()
        {
            _state += "Relax ";
        }
        public void Read()
        {
            _state += "Read ";
        }
        public void Write()
        {
            _state += "Write ";
        }
        public abstract void Study(); //абстрактний метод Study
        public string _name, _state;
    }


    class GoodStudent : Student //успадковується від абстрактного класу
    {
        public GoodStudent(string name) //викликає базовий конструктор класу Студент
            : base(name)
        {
            _state += "Good ";
        }
        override public void Study()
        {
            Read();
            Write();
            Read();
            Write();
            Relax();
        }
    }
    class BadStudent : Student
    {
        public BadStudent(string name)
            : base(name)
        {
            _state += "Bad ";
        }
        override public void Study()
        {
            Relax();
            Relax();
            Relax();
            Relax();
            Read();
        }
    }

    class Group
    {
        private string gname;
        List<Student> list = new List<Student>(); //список студентів 
        public Group(string name)
        {
            gname = name;
        }
        public void AddStudent(Student stdnt)
        { // додає студента в групу
            list.Add(stdnt);
        }
        public void AddGroup(Group grp)
        { //метод, що додає групу до групи
            foreach (Student stdnt in grp.list)
            {
                AddStudent(stdnt);
            }
            grp.ClearGroup();
        }

        private string GetInfo()
        { //створення рядку з інфою
            string info = "";
            info += gname + ": ";
            foreach (var student in list)
            {
                info += student._name + " ";
            }
            return info;
        }

        public void PrintInfo()
        { //виводить інформацію
            Console.WriteLine(this.GetInfo());
        }

        private string GetFullInfo()
        { //cтворення рядку з повною інфою
            string info = "";
            info += gname + ": ";
            if (list.Count == 0)
            {
                info = "Група порожня";
                return info;
            }
            foreach (var student in list)
            {
                info += student._name + ": " + student._state;
            }
            return info;
        }

        public void PrintFullInfo()
        { //виводить повну інформацію
            Console.WriteLine(this.GetFullInfo());
        }
        public void ClearGroup()
        {
            list.Clear();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {   //checking
            GoodStudent St1 = new GoodStudent("Ivanov");
            BadStudent St2 = new BadStudent("Burlaka");
            GoodStudent St3 = new GoodStudent("Bandyrin");
            BadStudent St4 = new BadStudent("Polonko");
            St1.Study();
            St2.Study();
            St3.Study();
            St4.Study();
            Group K17 = new Group("K17"); //створюємо групи
            Group K27 = new Group("K27");
            K17.AddStudent(St1); //Додаємо студентів 
            K17.AddStudent(St3);
            K27.AddStudent(St2);
            K27.AddStudent(St4);
            Console.WriteLine("Iнформацiя по К17:");
            K17.PrintInfo();
            Console.WriteLine("Iнформацiя по К27:");
            K27.PrintInfo();
            K17.AddGroup(K27); //додаємо групу К27 до групи К17
            Console.WriteLine("Повна iнформацiя про групу К17:");
            K17.PrintFullInfo();
            Console.WriteLine("Повна iнформацiя про групу К27:");
            K27.PrintFullInfo();
        }
    }
}