using System;
using System.Numerics;
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
            //CheckPrime();
            //PrintThree();
            //Check5();
            //TrySum5();
            //PrintXNumbers();
            //Print1ToX();
            //Fibonacci();
            //Ifswap();
            //CheckMinus();
            //BiggestOfThree();
            //SortThree();
            //NumberWord();
            //BiggestOfFive();
            //IntDoubleStr();
            //BonusPoints();
            //DrawTriangle();
            //PrintCycle();
            //PrintCycle2();
            //PrintSequence();
            //PlayingCards();

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
            Console.WriteLine(x == 0 ? "The number divides both by 5 and 7" : "The number does not divide by 5 and/or 7");
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
            Console.Write("The area of the trapezoid is: " + (a + b) * h / 2);
        }

        static void Rectangle() // Изчисли периметър и лице на правоъгълник по зададени страни a и b
        {
            float a, b;
            Console.Write("Input side A: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Input side B: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle perimeter is: " + 2 * (a + b));
            Console.WriteLine("Rectangle area is: " + (a * b));
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
            Console.Write(x * x + y * y <= Radius * Radius ? "Dot is in radius" : "Dot is not in radius");
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
            Console.WriteLine(d + "" + c + "" + b + "" + a); // обръщаме числото
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
            Console.Write((mask & n) != 0 ? "1 bit at that position" : "0 bits at that position"); // сравняваме го с битовете на числото, ако е вярно значи там има бит.
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
                Console.Write("n->" + n + " p->" + p + " v->" + v + " result = " + result);
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
            if (n > 2)
                for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); ++i) // закръгляме и поставяме под корен
                {
                    if (n % i == 0) prime = false;
                }
            Console.WriteLine(prime == true ? "The number \"" + n + "\" is a prime " : "The number \"" + n + "\" is not a prime ");

        }

        static void PrintThree()/*Програма, която да принтира 3 числа(цяло число в шестнадесетична бр.сист, полож.дробно число и отрицателно дробно число) 
            в 3 колони широки по 10 символа, всички числа трябва да са ляво подравнени като последните две числа трябва да се закръглят до втория знак*/
        {
            int hexNum = 2019;
            double decNum = 3.528;
            double negativeDecNum = -3.359;
            Console.WriteLine("----------------------------------");
            Console.WriteLine("|{0,-10:X}|{1,-10:f2}|{2,-10:f2}|", hexNum, decNum, negativeDecNum);
            Console.WriteLine("----------------------------------");
        }

        static void Check5() //Взимаме 2 числа и проверяваме колко числа между тях се делят на 5 без остатък.
        {
            int x, y;
            Console.Write("Input the first number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            y = int.Parse(Console.ReadLine());
            if (x > y)
                for (int i = y; i < x; i++)
                {
                    if (i % 5 == 0)
                        Console.WriteLine("Number " + i + " has no remainder after division");
                }
            else if (x < y)
                for (int i = x; i < y; i++)
                {
                    if (i % 5 == 0)
                        Console.WriteLine("Number " + i + " has no remainder after division");
                }
            else
                Console.WriteLine("the first and second number cannot hold the same value!");

        }

        static void TrySum5() //Прочитане на 5 числа от потребителя и валидирането им
        {
            int a, b, c, d, e;
            bool parseSuccess = false;
            do
            {
                Console.Write("Enter first number: ");
                parseSuccess = int.TryParse(Console.ReadLine(), out a);
                Console.WriteLine(parseSuccess);
            } while (!parseSuccess);
            do
            {
                Console.Write("Enter first number: ");
                parseSuccess = int.TryParse(Console.ReadLine(), out b);
                Console.WriteLine(parseSuccess);
            } while (!parseSuccess);
            do
            {
                Console.Write("Enter first number: ");
                parseSuccess = int.TryParse(Console.ReadLine(), out c);
                Console.WriteLine(parseSuccess);
            } while (!parseSuccess);
            do
            {
                Console.Write("Enter first number: ");
                parseSuccess = int.TryParse(Console.ReadLine(), out d);
                Console.WriteLine(parseSuccess);
            } while (!parseSuccess);
            do
            {
                Console.Write("Enter first number: ");
                parseSuccess = int.TryParse(Console.ReadLine(), out e);
                Console.WriteLine(parseSuccess);
            } while (!parseSuccess);

            Console.WriteLine("Total Sum is: " + (a + b + c + d + e));

        }

        static void PrintXNumbers() //Потребителят иска да вкара X числа и да види общата им сума.
        {
            int n, total = 0;
            Console.Write("how many numbers you want to add: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("add number " + i + " :");
                total += int.Parse(Console.ReadLine());
            }
            Console.Write("Total sum is: " + total);
        }

        static void Print1ToX() //Принтиране на всички числа от 1 до число което потребителя вкара.
        {
            int n;
            Console.Write("Input a number: ");
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void Fibonacci() //Изкарване на първите 100 числа от редицата на Фибоначи.
        {
            BigInteger x1 = 0;
            BigInteger x2 = 1;
            BigInteger sum;
            Console.WriteLine(x1);
            for (int i = 1; i < 100; i++)
            {
                sum = x1 + x2;
                x1 = x2;
                x2 = sum;
                Console.WriteLine(x2);

            }
        }

        static void Ifswap()
        {
            int a = 3;
            int b = 5;
            int c;
            if (a > b)
            {
                c = a;
                a = b;
                b = c;
            }
        }

        static void CheckMinus() // без да пресмята, проверява дали произведението на 3 числа е положително или отрицателно.
        {
            int a = 2;
            int b = -3;
            int c = 1;
            int count = 0;

            if (a < 0)
                count++;
            if (b < 0)
                count++;
            if (c < 0)
                count++;

            Console.Write(a != 0 && b != 0 && c != 0 ? (count % 2 == 0 ? "+" : "-") : "0");

        }

        static void BiggestOfThree()
        {
            int a = 22;
            int b = 5;
            int c = 7;

            if (a < b) a = b;
            if (a < c) a = c;
            Console.Write("Biggest number is " + a);

        } // провери, кое от 3те числа е най-голямо

        static void SortThree()
        {
            int a = 12;
            int b = 5;
            int c = 27;

            if (a > b)
            {
                if (a > c)
                    Console.WriteLine(b + " " + c + " " + a);
                else if (a < c)
                    Console.WriteLine(b + " " + a + " " + c);
            }

            if (a < b)
            {
                if (b > c)
                    Console.WriteLine(a + " " + c + " " + b);
                else if (b < c)
                    Console.WriteLine(a + " " + b + " " + b);
            }
        } // подредба на 3 числа от най-малко към най-голямо

        static void NumberWord()
        {
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;

                default:
                    Console.WriteLine("This is not a valid number!");
                    break;
            }
        }

        static void BiggestOfFive()
        {
            int a = 11;
            int b = 5;
            int c = 7;
            int d = 12;
            int e = 4;


            if (a < b) a = b;
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;

            Console.WriteLine("Biggest number is " + a);
        }

        static void IntDoubleStr()
        {
            Console.Write("Enter variable type (0 - int, 1 - double, 2 string): ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 0:
                    Console.Write("Input an integer: ");
                    int a = int.Parse(Console.ReadLine());
                    a++;
                    Console.Write("New integer: {0} ", a);
                    break;
                case 1:
                    Console.Write("Input a double: ");
                    double b = double.Parse(Console.ReadLine());
                    b++;
                    Console.Write("New double: {0} ", b);
                    break;
                case 2:
                    Console.Write("Input a string: ");
                    string c = Console.ReadLine();
                    c += "*";
                    Console.Write("New string: {0} ", c);
                    break;
            }
        } //ако е int/double ++1 , ако е string се добавя "*" накрая.

        static void BonusPoints()
        {
            int x;
            Console.Write("Input a number (0-9): ");
            x = int.Parse(Console.ReadLine());
            if (x >= 1 && x <= 9)
            {
                if (x >= 1 && x <= 3)
                {
                    x *= 10;
                    Console.WriteLine(x);
                }
                else if (x >= 4 && x <= 6)
                {
                    x *= 100;
                    Console.WriteLine(x);
                }
                else if (x >= 7 && x <= 9)
                {
                    x *= 1000;
                    Console.WriteLine(x);
                }
            }
            else
            {
                Console.Write("This is not a valid number!");
            }
        }

        static void DrawTriangle()
        {
            Console.Write("Please input a number: ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++) // външният цикъл ще обхожда редовете
            {
                for (int col = 1; col <= row; col++) // вътрешният цикъл ще обхожда колоните от текущият ред
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintCycle()
        {
            Console.Write("Input a number: ");
            int x = int.Parse(Console.ReadLine());
            for(int i = 1;i<=x;i++)
            {
                Console.Write(i + " ");
            }
        }

        static void PrintCycle2()
        {
            Console.Write("Input a number: ");
            int x = int.Parse(Console.ReadLine());
            for(int i = 1 ; i < x; i++)
            {
                if( i % (3*7) != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void PrintSequence()
        {
            int highest = int.MinValue;
            int lowest = int.MaxValue;
            Console.Write("How many numbers are you gonna input: ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 1;i<=number; i++)
            {
                Console.Write("Input a number: ");
                int x = int.Parse(Console.ReadLine());
                if (x > highest) highest = x;
                if (x < lowest) lowest = x;
            }
            Console.WriteLine("The lowest number is: "+ lowest+ " And the highest number is: "+highest);
        }

        static void PlayingCards()
        {
            //4 boi 13 karti 2 cikyla

            for(int i = 1;i<=4;i++) //външен цикъл за боите
            {
            for (int u = 1;u<=13;u++)
                {

                    switch (i)
                    {
                        case 1:
                            Console.Write("pika ");
                            break;
                        case 2:
                            Console.Write("spatiq ");
                            break;
                        case 3:
                            Console.Write("karo ");
                            break;
                        case 4:
                            Console.Write("kupa ");
                            break;
                    }

                    switch (u)
                    {
                        case 1:
                            Console.WriteLine("2");
                            break;
                        case 2:
                            Console.WriteLine("3");
                            break;
                        case 3:
                            Console.WriteLine("4");
                            break;
                        case 4:
                            Console.WriteLine("5");
                            break;
                        case 5:
                            Console.WriteLine("6");
                            break;
                        case 6:
                            Console.WriteLine("7");
                            break;
                        case 7:
                            Console.WriteLine("8");
                            break;
                        case 8:
                            Console.WriteLine("9");
                            break;
                        case 9:
                            Console.WriteLine("10");
                            break;
                        case 10:
                            Console.WriteLine("J");
                            break;
                        case 11:
                            Console.WriteLine("Q");
                            break;
                        case 12:
                            Console.WriteLine("K");
                            break;
                        case 13:
                            Console.WriteLine("A");
                            break;
                    }
                }
            }
        }

        static void PrintSequence3()
        {
         

        }
    }
}
