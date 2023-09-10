using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

//namespace ConsoleApp4
//{
//    public class Int
//    {
//        protected int _number;
//        public int n { get { return this._number; } set { this._number = value; } }
//        public Int(int number)
//        {
//            this._number = number;
//        }
//        public static Int operator ++(Int i)
//        {
//            i._number++;
//            return i;
//        }
//        public static Int operator +(Int i1, Int i2)
//        {
//            return new Int(i1.n + i2.n);
//        }
//        public override string ToString()
//        {
//            return this._number.ToString();
//        }

//        public static Int operator *(Int i1, Int i2)
//        {
//            return new Int(i1.n * i2.n);
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Int a = new Int(4);
//            Int b = new Int(6);
//            Int c = a + b;
//            Console.WriteLine(c);
//            Console.WriteLine(a + c);
//            Console.WriteLine(++c);
//            Console.WriteLine(c++);
//            Console.WriteLine(a*b);
//            Console.WriteLine(b*c);

//        }
//    }
//}

namespace ConsoleApp4
{
    public class Int
    {
        protected int _number;
        public int n { get { return this._number; } set { this._number = value; } }
        public Int(int number)
        {
            this._number = number;
        }
        public static Int operator ++(Int i)
        {
            i._number++;
            return i;
        }
        public static Int operator +(Int i1, Int i2)
        {
            return new Int(i1.n + i2.n);
        }
        public override string ToString()
        {
            return this._number.ToString();
        }

        public static Int operator *(Int i1, Int i2)
        {
            return new Int(i1.n * i2.n);
        }
        public override bool Equals(object a)
        {
            if (a == null)
                return false;
            return this.GetHashCode() == a.GetHashCode();
        }
        public override int GetHashCode()
        {
            return this.n.GetHashCode();
        }
        public static bool operator ==(Int a, Int b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Int a, Int b)
        {
            return !a.Equals(b);
        }
        public static bool operator >(Int a, Int b)
        {
            return a.n > b.n;
        }
        public static bool operator <(Int a, Int b)
        {
            return a.n < b.n;
        }
        public static bool operator true(Int i)
        {
            return i.n != 0;
        }
        public static bool operator false(Int i)
        {
            return i.n == 0;
        }
        public static Int operator &(Int i1, Int i2)
        {
            return ((i1.n != 0) && (i2.n != 0) ? new Int(1) : new Int(0));
        }
        public static implicit operator int(Int i)
        {
            return i.n;
        }
    }
    class Student
    {
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public int? age { get; set; }
        public Student(string? firstname, 
                       string? lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }
        public override string ToString()
        {
            return $"{firstname},{lastname},{age} лет";
        }
    }
    class Group
    {
        public string? name { get; set; }
        protected List<Student> students = new List<Student>();

        public Group(string name, params Student[] students)
        {
            this.name = name;
            foreach (Student student in students)
                this.students.Add(student);
        }
        public float AvgAge()
        {
            int sum = 0;
            foreach (Student student in this.students)
                sum += student.age ?? 0;
            return (float)sum / this.students.Count;
        }
        public Student this[ int index]
        {
            get
            {
                return this.students[index];
                    
            }
        }
        public List<Student> this[string lastname]
        {
            get
            {
                List<Student> students = new();
                foreach(Student student in this.students)
                    if (student.lastname == lastname)
                        students.Add(student);
                return students;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Group g = new Group("211", new Student("Саша", "Сашин", 16), new Student("Петя", "Петин", 17);
            Console
            

        }
    }
}