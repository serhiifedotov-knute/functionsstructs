namespace FunctionsStructs {
    internal class Program {

        //static int Sum(int[] numbers) {
        //    int sum = 0;
        //    for(int i = 0; i < numbers.Length; i++) {
        //        sum += numbers[i];
        //    }
        //    return sum;
        //}

        //static int Sum(int[] numbers, int initialValue) {
        //    int sum = Sum(numbers) + initialValue;
        //    return sum;
        //}

        // default parameter value 
        static int Sum(int[] numbers, int initialValue = 0) {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum + initialValue;
        }
    

        struct Square {
            public int a;
            public Square(int a) { this.a = a; }
        }
        struct Rectangle {
            public int a;
            public int b;

            public Rectangle(int a, int b) {
                this.a = a;
                this.b = b;
            }
        }
        struct Circle {
            public int r;

            public Circle(int r) { this.r = r;}
        }
        struct Triangle {
            public int a;
            public int h;

            public Triangle(int a, int h) {
                this.a=a;
                this.h=h;
            }
        }


        static float Area(Circle circle) {
            return 3.14f * circle.r * circle.r;
        }
        static float Area(Square square) {
            return square.a * square.a;
        }
        static float Area(Rectangle rect) {
            return rect.a * rect.b;
        }
        static float Area(Triangle tri) {
            return tri.a * tri.h / 2;
        }


        struct Vector2 {
            public float x;
            public float y;
        }

        struct Student {
            public string name;
            public int points;
            public string email;

            public int[] pointsForLesson;
            public string phone;

            // Constructor - is function insdide struct => which return struct

            public Student(string onlyName, int inputPoints = 0, string inputEmail = "") {
                this.name = onlyName;
                this.points = inputPoints;
                this.email = inputEmail;
                this.pointsForLesson = new int[3];
                this.phone = "";
            }
            //public Student(string onlyName) {
            //    this.name = onlyName;
            //    this.points = 0;
            //    this.email = "";
            //    this.pointsForLesson = new int[3];
            //    this.phone = "";
            //}
            // Constructor
            public Student(
                 string name2,
                 int points2,
                 string email2,
                 int[] pointsForLesson2,
                 string phone2
                ) {
                this.name = name2;
                this.points = points2;
                this.email = email2;
                this.pointsForLesson = pointsForLesson2;
                this.phone = phone2;
            }
        }
        static Student CreateStudentWithOnlyName(string name) {
           Student student = new Student();
           student.name = name;
           student.points = 0;
           student.email = "";
           student.pointsForLesson = new int[3];
           student.phone = "";
           return student;
        }

        struct SportCar {
            public int resultPlace;
            public string name;
            public float speed;
            public string producer;
            public string pilotName;
        }

        struct Group {
            public Student[] students;
        }

        struct University {
            public Group[] groups;
        }

        static void Print(string name, int points, string email) {
            Console.WriteLine($"Student:{name} got {points} contact email: {email}");
        }

        static void Print(Student student) {
            Console.WriteLine($"Student:{student.name} got {student.points} contact email: {student.email}");
            for (int i = 0; i < student.pointsForLesson.Length; i++) {
                Console.WriteLine($"Lesson:{i + 1} points got {student.pointsForLesson[i]}");
            }
            if (student.phone != null && student.phone.Length > 0) {
                Console.WriteLine($"Phone {student.phone}");
            }
        }

        // ALWAYS put               Return type  
        // static word first     (int, bool ,float, void)
        static int ReturnNumber5() {
            int result = 5;
            return result; // return ends function and повертає результат до того хто цю функцію викликав
        }

        static int FindMaxNumber(int[] numbers) {
            int maxNum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] > maxNum) {
                    maxNum = numbers[i];
                    Console.WriteLine("Maxnumber was changed");
                }
            }
            return maxNum;
        }

        // void - нічого 
        static void PrintMyName() {
            Console.WriteLine("My name is Serhii Fedotov");
            Console.WriteLine("1234578900987676551321");
            Console.WriteLine("-----------");
            Console.WriteLine("000000");
            return;
        }

        // with Overload usage
        static void Print(int x) {
            Console.WriteLine($"My integer = {x}");
        }
        static void Print(float x) {
            Console.WriteLine($"My Float = {x}");
        }
        static void Print(string x) {
            Console.WriteLine(x);
        }
        static void Print(Vector2 v) {
            Console.WriteLine($"({v.x},{v.y})");
        }

        // without Overload usage
        static void PrintInt(int x) {
            Console.WriteLine($"My integer = {x}");
        }
        static void PrintFloat(float x) {
            Console.WriteLine($"My Float = {x}");
        }
        static void PrintString(string x) {
            Console.WriteLine(x);
        }
        static void PrintVector(Vector2 v) {
            Console.WriteLine($"({v.x},{v.y})");
        }


        static int Area(int a, int b) {
            return a * b;
        }

        static float Area(float a, float b) {
            return a * b;
        }

        static float Area(float radius) {
            return 3.14f * radius * radius;
        }


        static int Add(int a, int b) {
            return a + b;
        }

        // Add(int a , int b ) =  Name + paramteres = UNIQUE
        //static int Add(int a , int b) {
        //    return a * b;
        //}

        static string Add(string str1, string str2) {
            return str1 + str2;
        }

        static Vector2 Add(Vector2 v1, int addNum) {
            Vector2 result = new Vector2();
            result.x = v1.x + addNum;
            result.y = v1.y + addNum;
            return result;
        }

        static Vector2 Add(Vector2 v1, Vector2 v2) {
            Vector2 result = new Vector2();
            result.x = v1.x + v2.x;
            result.y = v1.y + v2.y;
            return result;
        }

        static void Main(string[] args) { // функція, процедура, метод
            int[] numbers = { 1, 5, 7, 3, 4, 10 };
            int maxNum = FindMaxNumber(numbers);

            int[] numbers2 = { 3, 4, 15, 5, 5, 2 };
            int maxNum2 = FindMaxNumber(numbers2);

            int[] numbers3 = { 3, 4, 15, 5, 5, 2 };
            int maxNum3 = FindMaxNumber(numbers3);

            Console.WriteLine($"MaxNum1 = {maxNum} and MaxNum2 = {maxNum2}");

            // type of data        name of variable
            int name;



            int functionResult = ReturnNumber5();
            Console.WriteLine($"FunctionResult = {functionResult}");


            PrintMyName();

            float area = Area(5.5f, 2f);
            Console.WriteLine($"Rectangle Area: {area}");
            float circleArea = Area(5.6f);
            Console.WriteLine($"Circle Area : {circleArea}");

            int squareArea = Area(4, 2);


            int resultSum = Add(4, 5);
            string resultString = Add("Serhii", "Fedotov");

            Vector2 v1 = new Vector2();
            v1.x = 1.5f;
            v1.y = 2.5f;

            Vector2 v2 = new Vector2();
            v2.x = 3.5f;
            v2.y = 4.5f;

            Vector2 result = Add(v1, v2);

            Vector2 result2 = Add(result, 10);


            Print(resultSum);
            Print(circleArea);
            Print(resultString);
            Print(result2);






            int countOfStudents = 3;


            string[] namesForStudents = new string[countOfStudents];
            int[] pointsForStudents = new int[countOfStudents];
            string[] emailsForStudents = new string[countOfStudents];

            int[,] pointsForLessonForStudents = new int[countOfStudents, 3];

            namesForStudents[0] = "Serhii";
            pointsForStudents[0] = 15;
            emailsForStudents[0] = "serhhi.fedovo@asdasd.com";

            namesForStudents[1] = "Max";
            pointsForStudents[1] = 25;
            emailsForStudents[1] = "max.fedovo@asdasd.com";

            namesForStudents[2] = "Igor";
            pointsForStudents[2] = 35;
            emailsForStudents[2] = "igor.fedovo@asdasd.com";

            for (int i = 0; i < countOfStudents; i++) {
                Console.WriteLine($"Student:{namesForStudents[i]} got {pointsForStudents[i]} contact email: {emailsForStudents[i]}");
                //PrintStudent(namesForStudents[i], pointsForStudents[i], emailsForStudents[i]);
                Print(emailsForStudents[i], pointsForStudents[i], namesForStudents[i]);
            }


            Student[] students = new Student[countOfStudents];
            students[0] = new Student {
                name = "Serhii",
                points = 15,
                email = "serhhi.fedovo@asdasd.com",
            };
            students[0].pointsForLesson = new int[3];
            students[0].pointsForLesson[0] = 10;
            students[0].pointsForLesson[1] = 5;
            students[0].pointsForLesson[2] = 2;

            students[1] = new Student();
            students[1].name = "Igor";
            students[1].points = 22;
            students[1].email = "igor.fedovo@asdasd.com";
            students[1].pointsForLesson = new int[3];
            students[1].pointsForLesson[0] = 10;
            students[1].pointsForLesson[1] = 5;
            students[1].pointsForLesson[2] = 2;


            students[2] = new Student();
            students[2].name = "Max";
            students[2].points = 35;
            students[2].email = "max.fedovo@asdasd.com";
            students[2].pointsForLesson = new int[3];
            students[2].pointsForLesson[0] = 10;
            students[2].pointsForLesson[1] = 5;
            students[2].pointsForLesson[2] = 2;
            students[2].phone = "123121412";

            for (int i = 0; i < countOfStudents; i++) {
                Print(students[i]);
            }




            Student abc = new Student("sdfs", 234, "asdasd@asda.com",new int[] {1231,1312},"134234");
            Student onlyNameStudent = new Student("Serhii Alone");
            Student createdFromFunction = CreateStudentWithOnlyName("Serhii 2");




            Console.WriteLine($"Area circle {Area(new Circle(5))}");
            Console.WriteLine($"Area square {Area(new Square(5))}");
            Console.WriteLine($"Area rect {Area(new Rectangle(5,2))}");
            Console.WriteLine($"Area triangle {Area(new Triangle(5,10))}");



            int sum = Sum(new int[] { 1, 2, 3, 4, 5 });
            int sum2 = Sum(new int[] { 1, 2, 3, 4, 5 }) + 25;
            int sum3 = Sum(new int[] { 1, 2, 3, 4, 5 }, 35);








        }
    }
}