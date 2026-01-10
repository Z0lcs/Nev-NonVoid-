namespace NonVoid
{
    internal class Program
    {
        public class NonVoid
        {
            /// summary;
            /// Returns the square of num.
            /// summary;
            /// param name=num The number to be squared param;
            /// returns The square of num returns;
            public int Square(int num)
            {
                return num * num;
            }
            /// &lt;summary&gt;
            /// Returns the sum of num1, num2, and num3.
            /// &lt;/summary&gt;
            /// &lt;param name=&quot;num1&quot;&gt;First number in the sum&lt;/param&gt;
            /// &lt;param name=&quot;num2&quot;&gt;Second number in the sum&lt;/param&gt;
            /// &lt;param name=&quot;num3&quot;&gt;Third number in the sum&lt;/param&gt;
            /// &lt;returns&gt;The sum of num1, num2, and num3&lt;/returns&gt;
            public int SumThree(int num1, int num2, int num3)
            {
                return num1 + num2 + num3;
            }
            /// &lt;summary&gt;
            /// Returns the smaller value between num1 and num2.
            /// &lt;/summary&gt;
            /// &lt;param name=&quot;num1&quot;&gt;First number in minimum comparison&lt;/param&gt;
            /// &lt;param name=&quot;num2&quot;&gt;Second number in minimum comparison&lt;/param&gt;
            /// &lt;returns&gt;The smaller value&lt;/returns&gt;
            public int Smaller(int num1, int num2)
            {
                if (num1 > num2) return num2;
                else if (num2 > num1) return num1;
                else return num1;

                //return Math.Min(num1, num2);
        }
            /// &lt;summary&gt;
            /// Returns one of five fortune cookie responses chosen at random.

            /// If the random number = 0 the method returns &quot;Your future looks bright;
            /// If the random number = 1 the method returns &quot;I see love in your future;
            /// If the random number = 2 the method returns &quot;Maybe you better stay home today;
            /// If the random number = 3 the method returns &quot;You will have fame and fortune;
            /// If the random number = 4 the method returns &quot;Happiness you will have;
            /// &lt;/summary;
            /// &lt;return;A string response&lt;/return;
            public string FortuneCookie()
            {
                int num = new Random().Next(0, 5);
                // TODO : Return fortune cookie response based on random number

                switch (num)
                {
                    case 0:
                        return "Your future looks bright";
                    case 1:
                        return "I see love in your future";
                    case 2:
                        return "Maybe you better stay home today";
                    case 3:
                        return "You will have fame and fortune";
                    case 4:
                        return "Happiness you will have";
                    default:
                        return "Bad luck, no fortune today!";
                }
            }
            /// &lt;summary&gt;
            /// Returns a response depending upon month&#39;s value.
            /// If month &gt;= 1 &amp;&amp; month &lt;= 3 it returns &quot;winter&quot;
            /// If month &gt;= 4 &amp;&amp; month &lt;= 6 it returns &quot;spring&quot;
            /// If month &gt;= 7 &amp;&amp; month &lt;= 9 it returns &quot;summer&quot;
            /// If month &gt;= 10 &amp;&amp; month &lt;= 12 it returns &quot;fall&quot;
            /// &lt;/summary&gt;
            /// &lt;param name=&quot;month&quot;&gt;The numerical month of the year&lt;/param&gt;
            /// &lt;returns&gt;A string response&lt;/returns&gt;
            public string Season(int month)
            {
                // TODO : Return season based on month value
                if (month == 1 || month == 2 || month == 12) return "winter";
                else if (month == 3 || month == 4 || month == 5) return "spring";
                else if (month == 6 || month == 7 || month == 8) return "summer";
                else if (month == 9 ||month == 10 || month ==11) return "autumn";
                else throw new NotImplementedException();
            }
            /// &lt;summary&gt;
            /// Determines if num is odd or even.
            /// If num is even it returns the string &quot;even&quot;;
            /// otherwise it returns the string &quot;odd&quot;.
            /// &lt;/summary&gt;
            /// &lt;param name=&quot;num&quot;&gt;Number used in comparison&lt;/param&gt;
            /// &lt;returns&gt;The string &quot;even&quot; or the string &quot;odd&quot;&lt;/returns&gt;
            public string EvenOdd(int num)
            {
                // TODO : Determine if number is even or odd
                string ans = "";
                if (num % 2 == 0) return ans = "even";
                else return ans = "odd";
                

            }

            public static void Main(string[] args)
            {
                NonVoid app = new NonVoid();
                Console.WriteLine("Test square method");
                Console.WriteLine("==================");
                Console.WriteLine("The square of 5 is " + app.Square(5));
                Console.WriteLine("The square of 12 is " + app.Square(12));
                Console.WriteLine();
                Console.WriteLine("Test sumThree method");
                Console.WriteLine("====================");
                Console.WriteLine("The sum of 10, 20, 30 is " + app.SumThree(10, 20, 30));
                Console.WriteLine("The sum of 15, 100, 75 is " + app.SumThree(15,
                100, 75));
                Console.WriteLine();
                Console.WriteLine("Test smaller method");
                Console.WriteLine("====================");
                Console.WriteLine("Which is smaller 10 or 35 ? " + app.Smaller(10,
                35));
                Console.WriteLine("Which is smaller 100 or 50 ? " + app.Smaller(100,
                50));
                Console.WriteLine();
                Console.WriteLine("Test fortuneCookie method");
                Console.WriteLine("=========================");
                Console.WriteLine("Your fortune cookie says " +
                app.FortuneCookie());
                Console.WriteLine("Your fortune cookie says " +
                app.FortuneCookie());
                Console.WriteLine();
                Console.WriteLine("Test season method");
                Console.WriteLine("===================");
                Console.WriteLine("The month of March is in the " + app.Season(3));
                Console.WriteLine("The month of July is in the " + app.Season(7));
                Console.WriteLine();
                Console.WriteLine("Test evenOdd method");
                Console.WriteLine("===================");
                Console.WriteLine("The number 84 is " + app.EvenOdd(84));
                Console.WriteLine("The number 27 is " + app.EvenOdd(27));

            }
        }
    }
}
