using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LAB8
{
    public interface IMoney
    {
        public void give_money();
    }
    public class Terminal
    {
        public void give_money(IMoney clas)
        {
            clas.give_money();
        }
    }

    public enum Pole
    {
        Fizica,
        Matem,
        Yasic,
        Pocket_money
    }
    class Child : IMoney
    {
        public string Surname { get; set; }
        public int Zrenie { get; set; }
        private int Age { get; set; }
        private int Pocket_money { get; set; } = 0;
        private string _name;
        public delegate void Pocket();
        public event Pocket Notify;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Человек не может быть без имени...");
                }
                _name = value;
            }
        }
        public Child(string surname, string name, int zrenie, int age)
        {
            _name = name;
            Surname = surname;

            if (zrenie >= -10 && zrenie <= 10)
            {
                Zrenie = zrenie;
            }
            else
            {
                Console.WriteLine("Такого зрения не существует!");
                Console.ReadLine();
                Console.Clear();
                return;
            }
            if (age >= 16 && age <= 100)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Возраст неверный!");
                Console.ReadLine();
                Console.Clear();
                return;
            }

        }

        public string this[Pole pole]
        {
            get
            {
                switch (pole)
                {
                    case Pole.Pocket_money: return "карманные деньги: " + Convert.ToString(Pocket_money) + " грiвiнь";
                    default: return null;
                }
            }
            set
            {
                switch (pole)
                {
                    case Pole.Pocket_money: Pocket_money = Convert.ToInt32(value); break;
                }
            }
        }
        public void Vivod()
        {
            Console.WriteLine("Возраст абитуриента:");
            Console.WriteLine(Age);
            Console.WriteLine("Фамилия абитуриента:");
            Console.WriteLine(Surname);
            Console.WriteLine("Имя абитуриента:");
            Console.WriteLine(_name);
            Console.WriteLine("Зрение абитуриента:");
            Console.WriteLine(Zrenie);
            Notify?.Invoke();
            Console.WriteLine(this[Pole.Pocket_money]);
        }
        public void Vivod(string pole)
        {
            if (pole == "Age")
            {
                Console.WriteLine("Возраст абитуриента:");
                Console.WriteLine(Age);
            }
            if (pole == "Surname")
            {
                Console.WriteLine("Фамилия абитуриента:");
                Console.WriteLine(Surname);
            }
            if (pole == "Name")
            {
                Console.WriteLine("Имя абитуриента:");
                Console.WriteLine(_name);
            }
            if (pole == "Zrenie")
            {
                Console.WriteLine("Зрение абитуриента:");
                Console.WriteLine(Zrenie);
            }
        }
        public void give_money()
        {
            Pocket_money += 1;
        }
    }
    class Uchenik : Child, IMoney
    {
        protected int SredBall { get; set; }
        public Uchenik(string surname, string name, int zrenie, int age, int sredBall) : base(surname, name, zrenie, age)
        {
            if (sredBall >= 1 && sredBall <= 10)
            {
                SredBall = sredBall;
            }
            else
            {
                Console.WriteLine("There is no such score");
                Console.ReadLine();
                Console.Clear();
                return;
            }
        }
        new public void Vivod()
        {
            base.Vivod();
            Console.WriteLine("средний балл абитуриента:");
            Console.WriteLine(SredBall);

        }
        new public void Vivod(string pole)
        {
            base.Vivod(pole);
            if (pole == "SredBall")
            {
                Console.WriteLine("средний балл абитуриента:");
                Console.WriteLine(SredBall);
            }
        }
        new public void give_money()
        {
            for (int i = 0; i < 10; i++)
                base.give_money();
        }
    }
    class Abiturient : Uchenik, IMoney
    {
        protected int Matem { get; set; }
        protected int Fizica { get; set; }
        protected int Yasic { get; set; }
        double BallItog = 0;
        public Abiturient(string surname, string name, int zrenie, int age,
                int matem, int fizica, int yasic, int sredBall) : base(surname, name, zrenie, age, sredBall)
        {
            if (matem >= 10 && matem <= 100)
            {
                Matem = matem;
            }
            else
            {
                Console.WriteLine("There is no such score");
                Console.ReadLine();
                Console.Clear();
                return;
            }
            if (fizica >= 10 && fizica <= 100)
            {
                Fizica = fizica;
            }
            else
            {
                Console.WriteLine("There is no such score");
                Console.ReadLine();
                Console.Clear();
                return;
            }
            if (yasic >= 10 && yasic <= 100)
            {
                Yasic = yasic;
            }
            else
            {
                Console.WriteLine("There is no such score");
                Console.ReadLine();
                Console.Clear();
                return;
            }
        }
        new public string this[Pole pole]
        {
            get
            {
                switch (pole)
                {
                    case Pole.Fizica: return "физика абитуриента: " + Convert.ToString(Fizica);
                    case Pole.Matem: return "математика абитуриента: " + Convert.ToString(Matem);
                    case Pole.Yasic: return "язык абитуриента: " + Convert.ToString(Yasic);
                    default: return null;
                }
            }
            set
            {
                switch (pole)
                {
                    case Pole.Fizica: Fizica = Convert.ToInt32(value); break;
                    case Pole.Matem: Matem = Convert.ToInt32(value); break;
                    case Pole.Yasic: Yasic = Convert.ToInt32(value); break;
                }
            }
        }
        public void Raschet()
        {
            Console.WriteLine("ЦT:");
            int Mat = Matem;
            int Fiz = Fizica;
            int Yaz = Yasic;
            int SrednBall = SredBall;
            if (Mat < 10 && Fiz < 10 && Yaz < 10)
            {
                Console.WriteLine("You need to pass the threshold");
                Console.Clear();
                return;
            }
            else if (Mat > 100 && Fiz > 100 && Yaz > 100)
            {
                Console.WriteLine("Points cannot be higher than 100");
                Console.ReadLine();
                Console.Clear();
                return;
            }
            else if (SrednBall < 1)
            {
                Console.WriteLine("The average score can not be without an integer");
                Console.Clear();
                return;
            }
            else if (SrednBall > 10)
            {
                Console.WriteLine("The maximum score is '10'");
                Console.Clear();
                return;
            }
            BallItog = (SrednBall * 10) + (Mat + Fiz + Yaz);
            Console.WriteLine($"BallItog = {BallItog}");
            Console.WriteLine("You can apply to our university for paid and free training");
            Console.WriteLine("Let's decide on these options!");
            Console.WriteLine("'1' this is free training. '2' paid training");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    if (BallItog < 318)
                    {
                        Console.WriteLine("You can't enroll in this specialty for free with such a final score");
                    }
                    else if (BallItog > 318 && BallItog < 327)
                    {
                        Console.WriteLine("Electronic computing facilities");
                    }
                    else if (BallItog > 327 && BallItog < 352)
                    {
                        Console.WriteLine("Now you can choose a specialty: 1 - 'Electronic computing facilities'. 2 - 'Computing machines, systems and networks'");
                        int a = Convert.ToInt32(Console.ReadLine());
                        switch (a)
                        {
                            case 1: Console.WriteLine("Electronic computing facilities"); break;
                            case 2: Console.WriteLine("Computing machines, systems and networks"); break;
                            default: Console.WriteLine("There is no such option!!!"); break;

                        }
                    }
                    else if (BallItog > 352 && BallItog < 357)
                    {
                        Console.WriteLine("Now you can choose a specialty: 1 - 'Electronic computing facilities'. 2 - 'Computing machines, systems and networks'. 3 - 'Computer science and programming technologies'");
                        int b = Convert.ToInt32(Console.ReadLine());
                        switch (b)
                        {
                            case 1: Console.WriteLine("Electronic computing facilities"); break;
                            case 2: Console.WriteLine("Computing machines, systems and networks"); break;
                            case 3: Console.WriteLine("Computer science and programming technologies"); break;
                            default: Console.WriteLine("There is no such option!!!"); break;
                        }
                    }
                    else if (BallItog > 357 && BallItog < 401)
                        Console.WriteLine("Now you can choose a specialty: 1 - 'Electronic computing facilities'. 2 - 'Computing machines, systems and networks'. 3 - 'Computer science and programming technologies'. 4 - 'Information technology software'");
                    int c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1: Console.WriteLine("Electronic computing facilities"); break;
                        case 2: Console.WriteLine("Computing machines, systems and networks"); break;
                        case 3: Console.WriteLine("Computer science and programming technologies"); break;
                        case 4: Console.WriteLine("Information technology software"); break;
                        default: Console.WriteLine("There is no such option!!!"); break;
                    }
                    break;
                case 2:
                    if (BallItog < 156)
                    {
                        Console.WriteLine("You can't enroll in this specialty for free with such a final score");
                    }
                    else if (BallItog > 156 && BallItog < 209)
                    {
                        Console.WriteLine("Computing machines, systems and networks");
                    }
                    else if (BallItog > 209 && BallItog < 287)
                    {
                        Console.WriteLine("Now you can choose a specialty: 1 - 'Electronic computing facilities'. 2 - 'Computing machines, systems and networks'");
                        int d = Convert.ToInt32(Console.ReadLine());
                        switch (d)
                        {
                            case 1: Console.WriteLine("Electronic computing facilities"); break;
                            case 2: Console.WriteLine("Computing machines, systems and networks"); break;
                            default: Console.WriteLine("There is no such option!!!"); break;

                        }
                    }
                    else if (BallItog > 287 && BallItog < 310)
                    {
                        Console.WriteLine("Now you can choose a specialty: 1 - 'Electronic computing facilities'. 2 - 'Computing machines, systems and networks'. 3 - 'Computer science and programming technologies'");
                        int e = Convert.ToInt32(Console.ReadLine());
                        switch (e)
                        {
                            case 1: Console.WriteLine("Electronic computing facilities"); break;
                            case 2: Console.WriteLine("Computing machines, systems and networks"); break;
                            case 3: Console.WriteLine("Computer science and programming technologies"); break;
                            default: Console.WriteLine("There is no such option!!!"); break;
                        }
                    }
                    else if (BallItog > 310 && BallItog < 401)
                        Console.WriteLine("Now you can choose a specialty: 1 - 'Electronic computing facilities'. 2 - 'Computing machines, systems and networks'. 3 - 'Computer science and programming technologies'. 4 - 'Information technology software'");
                    int o = Convert.ToInt32(Console.ReadLine());
                    switch (o)
                    {
                        case 1: Console.WriteLine("Electronic computing facilities"); break;
                        case 2: Console.WriteLine("Computing machines, systems and networks"); break;
                        case 3: Console.WriteLine("Computer science and programming technologies"); break;
                        case 4: Console.WriteLine("Information technology software"); break;
                        default: Console.WriteLine("There is no such option!!!"); break;
                    }
                    break;
                default: Console.WriteLine("There is no such option!!!"); break;
            }
        }
        new public void Vivod()
        {
            base.Vivod();
            Console.WriteLine(this[Pole.Fizica]);
            Console.WriteLine(this[Pole.Matem]);
            Console.WriteLine(this[Pole.Yasic]);
            Raschet();
            Console.WriteLine("итоговый балл абитуриента:");
            Console.WriteLine(BallItog);

        }
        new public void Vivod(string pole)
        {
            base.Vivod(pole);
            if (pole == "Fizica")
            {
                Console.WriteLine("физика абитуриента:");
                Console.WriteLine(Fizica);
            }
            if (pole == "Matem)")
            {
                Console.WriteLine("математика абитуриента:");
                Console.WriteLine(Matem);
            }
            if (pole == "Yasic")
            {
                Console.WriteLine("язык абитуриента:");
                Console.WriteLine(Yasic);
            }
        }
        new public void give_money()
        {
            for (int i = 0; i < 2; i++)
                base.give_money();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Terminal term = new Terminal();
            Console.WriteLine("Hello");
            int Zrenie = 0, matem = 0, fizica = 0, yazic = 0, age = 0, srednBall = 0;
            string _Name = "name", surname = "Surname";
            Console.WriteLine("Enter surname");
            surname = Console.ReadLine();
            Console.WriteLine("Enter name");
            _Name = Console.ReadLine();
            Console.WriteLine("Enter zrenie");
            Zrenie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fizica grade");
            fizica = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter matem grade");
            matem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter yazic grade");
            yazic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter srednBall grade");
            srednBall = Convert.ToInt32(Console.ReadLine());
            Abiturient NIK = new Abiturient(surname, _Name, Zrenie, age, matem, fizica, yazic, srednBall);

            while (true)
            {
                Console.WriteLine("попросить милостыню у мамы?\nenter-да        esc-нет");
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Enter)
                    NIK.Notify += NIK.give_money;
                if (key == ConsoleKey.Escape)
                    break;
            }
            NIK.Vivod();
            NIK.Vivod("Age");
            NIK.Vivod("Name");
            Console.ReadKey();
        }
    }
}