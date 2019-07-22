using System;
namespace app1
{
    class Program
    {
        static void Main()
        {
            //CheckYears();
            // Console.WriteLine("");
            //CheckEven();
            //Check5and7();
            //CheckThird();
            //CheckThirdBit();
            //Trapezoid();
            //Rectangle();
            //WeightOnMoon();
            //CheckDotInRange();
            //CheckDotInRangeAndInSquare();
            //NumberDivision();
            //CheckBit();
            //ChangeBit();
            CheckPrime();
        }

        static void CheckYears() // Добавяне на 10 години към вписаните
        {
            string years;

            Console.Write("Input your age: ");
            years = Console.ReadLine(); // input
            int yearsint = int.Parse(years); // string -> integer

            DateTime today = DateTime.Now; // today = today date
            DateTime future = DateTime.Today.AddYears(10); // future = today date + 10
            DateTime futureYear = future.AddYears(yearsint); // futureYear = future + age
            int predict = futureYear.Year - today.Year; // futureYear - today = age + 10
            Console.WriteLine("Your age 10 years from now will be: " + predict);
            
        }
         static void CheckEven() // Проверка дали дадено цяло число е четно или нечетно
        {
            string number;
            int x;
            Console.Write("Input a number to check if it is even: ");
            number = Console.ReadLine();
            x = int.Parse(number) % 2;
            Console.WriteLine(x == 0 ? "The number is even" : "The number is not even");
        }

        static void Check5and7() // Проверка дали дадено цяло число се дели и на 5 и на 7
        {
            string number;
            int x;
            Console.Write("Input a number to check if it divides by 5 and 7: ");
            number = Console.ReadLine();
            x = int.Parse(number) % 35; // 35 е най-малкото число, което се дели и на 5 и на 7
            Console.WriteLine(x==0 ? "The number divides both by 5 and 7" : "The number does not divide by 5 and/or 7");
        }

        static void CheckThird() // Проверка дали третата цифра на цяло число(от дясно на ляво) е 7
        {
            int x;
            string number;
            number = Console.ReadLine();
            x = (int.Parse(number) / 100) % 10;
            Console.WriteLine(x == 7 ? "Third digit(right to left) is 7" : "Third digit(right to left) is not 7");
        }
        static void CheckThirdBit() // Проверка дали дадено число има 1 в третия си бит
        {
            bool thirdBit;
            Console.Write("Input your number to check if its third bit is 0 or 1: "); // потребителя вкарва число
            thirdBit = (int.Parse(Console.ReadLine()) & 8) != 0; //сравняваме го с 8(00000100), ако е различно от 0 е true, тоест е върнало единица от третия бит.
            Console.WriteLine(thirdBit == true ? "The number has 1 in its third bit" : "The number doesn't have 1 in its third bit");
        }

        static void Trapezoid() // Изчисли площ на трапец по зададени страни и височина.
        {
            float a, b, h;
            Console.Write("Input side A: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Input side B: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Input Height: ");
            h = float.Parse(Console.ReadLine());
            Console.Write("The area of the trapezoid is: " + (a+b)*h/2);
        }

        static void Rectangle() // Изчисли периметър и лице на правоъгълник по зададени страни a и b
        {
            float a, b;
            Console.Write("Input side A: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Input side B: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle perimeter is: " + 2*(a+b));
            Console.WriteLine("Rectangle area is: " + (a*b));
        }

        static void WeightOnMoon() // Изчисли колко би тежал човек с дадено тегло на луната
        {
            Console.Write("Input your weight: ");
           Console.Write("Your weight on the moon will be: " + float.Parse(Console.ReadLine()) * 0.17);
        }

        static void CheckDotInRange() // Проверка дали точка с дадена позиция {x,y} е в окръжността на K{0,0}, R=5.
        {
            int x, y;
            const int Radius = 5;
            Console.Write("Input x: ");
           x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write(x*x + y*y <= Radius*Radius ? "Dot is in radius" : "Dot is not in radius" );
        }
        static void CheckDotInRangeAndInSquare() // Проверка дали точка с дадена позиция {x,y} е в окръжността на K{0,0}, R=5 И в правоъгълник {-1,1} {5,5}
        {
            int x, y;
            const int Radius = 5;
            const int X1 = -1;
            const int Y1 = 1;
            const int X2 = 5;
            const int Y2 = 5;
            bool inRadius, inRectangle;
            Console.Write("Input x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input y: ");
            y = Convert.ToInt32(Console.ReadLine());
            inRadius = x * x + y * y <= Radius * Radius; // Проверка дали е в окръжността
            inRectangle = (x >= X1 && x <= X2) && (y >= Y1 && y <= Y2); // Проверка дали е в правоъгълника
            Console.Write(inRadius && inRectangle ? "The dot is both in rectangle and in radius" : "the dot is not in the rectangle and/or radius");
        }

        static void NumberDivision() // Различни операции с цифрите на четирицифрено число
        {
            int a, b, c, d;
            int number;
            Console.Write("Input a 4 digit number: ");
            number = Convert.ToInt32(Console.ReadLine());
            a = (number / 1000) % 10;
            b = (number / 100) % 10;
            c = (number / 10) % 10;
            d = number % 10;

            Console.WriteLine(a + b + c + d); // сбор на всичките цифри
            Console.WriteLine(d+""+c+""+b+""+a); // обръщаме числото
            Console.WriteLine(d + "" + a + "" + b + "" + c); // последната цифра на място на първата
            Console.WriteLine(a + "" + c + "" + b + "" + d); // втората цифра на място на третата
        }

        static void CheckBit()// Проверка дали бит 'p' в числото 'n' e 0 или 1
        {
            int n, p;
            int i = 1;
            Console.Write("Input a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the bit you want to check: ");
            p = Convert.ToInt32(Console.ReadLine());
            int mask = i << p; // преместваме единственият бит на 1(0000 0001) вляво с 'p' позиции
            Console.Write((mask & n) !=0 ? "1 bit at that position" : "0 bits at that position"); // сравняваме го с битовете на числото, ако е вярно значи там има бит.
        }

        static void ChangeBit() //Променяме бит номер p, в числото n с бит v(0/1)
        {
            int n, p, v;
            int i = 1;
            Console.Write("Input a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the bit you want to change: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of the new bit 0/1: ");
            v = Convert.ToInt32(Console.ReadLine());
            if (v == 1)
            {
                int mask = i << p;
                int result = mask | n; // ако на една и съща позиция на двете числа има поне една единица, значи е единица
                Console.Write("n->"+n+" p->"+p+" v->"+v+" result = "+result);
            }
            else if (v == 0)
            {
                int mask = ~(i << p); //обръща преместването , така 1(0000 0001) става 1111 1110 и дефакто местим 0-та.
                int result = mask & n; // ако на една и съща позиция на двете числа има единица е единица.
                Console.Write("n->" + n + " p->" + p + " v->" + v + " result = " + result);
            }
            else
            Console.Write("Wrong value for v!"); 
        }
        
        static void CheckPrime() // Проверка дали дадено число е просто(дели се дели само на себе си и на единица без остатък)
        {
         
            int n;
            bool prime = true;
            Console.Write("Ïnput a number: ");
            n = int.Parse(Console.ReadLine());
            if(n > 2)
            for(int i = 2; i<=Math.Ceiling(Math.Sqrt(n));++i) // закръгляме и поставяме под корен
                {
                    if (n % i == 0) prime = false;
                }
            Console.WriteLine(prime == true ? "The number \""+n+"\" is a prime " : "The number \""+n+"\" is not a prime ");
          
        }
    }
}
