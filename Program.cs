using System.Collections.Concurrent;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            #region Ternary
            //bool medeniHal=true;
            //int a = 125;
            //Console.WriteLine(a==123?"Your Entry is lucky..":"Unlucky...");


            //object obj = 123;
            //int a =(int)obj;
            //Console.WriteLine(obj);

            //Console.WriteLine("Please choose the number..");
            //int number =int.Parse(Console.ReadLine());
            //int a = 125;
            //Console.WriteLine(a == 123 ? "Your Entry is lucky.." : "Unlucky...");


            #endregion

            #region Operations...
            //Console.WriteLine("Please add your name ...");


            //object x = "Ahmet";
            //int? y = x as int?;
            //if (y != null)
            //    Console.WriteLine("Your entry successful");
            //else
            //    Console.WriteLine("Unseccessful");
            //Console.WriteLine(y);
            //int a = 4;
            //int b = a++;// entry  4// in memory 5
            //int c = ++b;// entry 5// in memory 6
            //Console.WriteLine(b);
            //Console.WriteLine(c);



            //int b = 6;
            //int c = b++;// entry 6 // in memory 7 b=7 c=5 d=5
            //int d = --c;//  entry 5// in memory 6 
            ////Console.WriteLine(c + d);
            //Console.WriteLine(d);
            //Console.WriteLine(c);
            //Console.WriteLine(b);

            //int a = 45;
            //int b = 56;
            //Console.WriteLine(a ==b);

            //int a = 5;// cikti 6 yaddashda 6
            //int b= a++;// cikti 6 yaddashda 5
            //int c= ++b;// cikti 6
            //int d = c;//cikti 6

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            #endregion

            #region Cast Operations
            //int ascii = 65;
            //char b = (char)ascii;
            //Console.WriteLine(b);
            #endregion

            #region Null-Coalescing
            //string a = null;
            //Console.WriteLine(a ?? "Hello World ");// Null Coalescing
            ////Əgər a nulldırsa hello world u yaz 
            #endregion

            #region Null-Coalesing Assignment
            //string b = null;
            //Console.WriteLine(b??="Hello World");// Null Coalescing Assignment
            //Console.WriteLine(b);
            #endregion

            #region Switch task1
            //string a = "Ahmet";
            //switch (a)
            //{
            //    case "Mehmet":
            //        Console.WriteLine("Verilən dəyər 0 a bərabərdi");
            //        break;
            //    case "Ayşe":
            //        Console.WriteLine("Verilən dəyər 100 ə bərabərdi");
            //        break;

            //    case "Sukluman":
            //        goto case "Ayşe";

            //    default:
            //        Console.WriteLine("Verilen deyer Ahmet-e aiddi");
            //        break;
            //}

            //string name = "";
            //int i = 23;
            //switch (i)
            //{
            //    case 10:
            //        name = "Anam";
            //        break;
            //    case 11:
            //        name = "Atam";
            //        break;
            //     case 12:
            //        name = "Qardaşım";
            //        break;
            //    case 23:
            //        name = "Annecim";
            //        break;
            // }
            //Console.WriteLine(name);
            #endregion

            #region Switch-Expression
            //int a = 10;
            //string month = a switch
            //{
            //    10 => "January",
            //     11 => "February",
            //      12 => "March",
            //       23 => "April"
            //};
            //Console.WriteLine(month);
            #endregion

            #region Switch task2
            //Console.WriteLine("Please enter first any number");
            //int first =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("******");
            //Console.WriteLine("Please enter second any number");
            //int second =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("******");
            //Console.WriteLine("Please choose the operation : + * - / %");
            //char operation =Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("******");

            //switch (operation) 
            //{
            //    case '+':
            //        Console.WriteLine(first + second);
            //        break;

            //    case '-':
            //        Console.WriteLine(first - second);
            //        break;
            //    case '*':
            //        Console.WriteLine(first * second);
            //        break;
            //    case '/':
            //        Console.WriteLine(first / second);
            //        break;

            //}
            #endregion

            #region Switch task3
            //while (true)
            //{
            //    Console.WriteLine("Please enter first any number");
            //    int first = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("******");
            //    Console.WriteLine("Please enter second any number");
            //    int second = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("******");
            //    Console.WriteLine("Please choose the operation : + * - / %");
            //    char operation = Convert.ToChar(Console.ReadLine());
            //    Console.WriteLine("******");

            //    var result = operation switch
            //    {
            //        '+'=> first + second,
            //        ':' => first + second,
            //        '*' => first + second,
            //        '-' => first + second,
            //    };
            //    Console.WriteLine(result);

            //}
            #endregion

            #region Switch Tuple Patterns
            //string name = "";
            //int age = 22;
            //int age1 = 23;

            //switch (age ,age1)
            //{
            //    case (22,23):
            //        name = "Naila";
            //        break;
            //    case (24,25):
            //        name = "Fidan";
            //        break;
            //    case (21,22):
            //        name = "Vafa";
            //        break;
            //}
            //Console.WriteLine(name);


            //int age = 22;
            //int age1 = 23;

            //string name = (age, age1) switch
            //{
            //    (22,23)=> "Naila",
            //    (24,25)=>"Vafa",
            //};
            //Console.WriteLine(name);

            #endregion

            #region Switch Property PATTERNS
            //Students students = new Students()
            //{
            //    Name = "Naila",
            //    LastName ="Bayramova",
            //    Age = 25,
            //};

            //;
            //double salary = students switch
            //{
            //    //case "Bayramova":
            //    //    salary = 2500;
            //    //    break;

            //    //case "Dadaşova":
            //    //    salary = 2200;
            //    //    break;

            //    //case "Bədirxanov":
            //    //    salary = 200;
            //    //    break;

            //    { LastName: "Bayramov" } => 2690,
            //    { LastName: "Bayramova", Age: 24 } => 290,
            //    var x when x.Age==25 && x.LastName=="Bayramova" => 260,
            //    var x when x.Age==34 && x.LastName=="Dadaşova" => 2300,
            //    var x when x.Age==45 && x.LastName=="Bədirxanov" => 348,
            //    { LastName: "Dəstəgul" } when !true =>450,

            //};
            //Console.WriteLine(salary);
            #endregion

            #region Mixed IF..Else task
            //int i = 10;
            //if (i != 10)
            //{

            //    Console.WriteLine("i is not  10 ");
            //}
            //else
            //{
            //    Console.WriteLine("i is 10");
            //}
            #endregion

            #region Switch task 4
            //Daxil edilən bal(0 - 100) əsasında qiymət dərəcəsini(A, B, C, D, E, F) göstərən proqram yazın.
            //Console.WriteLine("0-100  arasında bir rəqəm seç ");
            //int result = Convert.ToInt32(Console.ReadLine());

            //switch (result / 10)
            //{
            //    case 5:
            //        Console.WriteLine("F");
            //        break;
            //    case 6:
            //        Console.WriteLine("E");
            //        break;
            //    case 7:
            //        Console.WriteLine("D");
            //        break;
            //    case 8:
            //        Console.WriteLine("C");
            //        break;
            //    case 9:
            //        Console.WriteLine("B");
            //        break;
            //    case 10:
            //        Console.WriteLine("A");
            //        break;
            //}
            #endregion

            #region TASK ATM sistemi 
            //int balans = 1000;
            //bool davamEt = true;

            //while (true)
            //{
            //    Console.WriteLine("\n1-4 choose the number ");
            //    Console.WriteLine("\n1 Balansı yoxla");
            //    Console.WriteLine("\n2 Pul çıxar");
            //    Console.WriteLine("\n3 Pul yatır");
            //    Console.WriteLine("\n4 Çıxış ");
            //    Console.Write("Seçiminizi edin: ");

            //    int number = Convert.ToInt32(Console.ReadLine());


            //    switch (number)
            //    {
            //        case 1:
            //            Console.WriteLine($"Your outstanding balance {balans}");

            //            break;
            //        case 2:

            //            Console.Write("Return salary: ");
            //            int cekilenPul = Convert.ToInt32(Console.ReadLine());

            //            if (balans >= cekilenPul)
            //            {
            //                balans -= cekilenPul;
            //                Console.WriteLine($"{cekilenPul} AZN çıxarıldı. Yeni balans: {balans} AZN");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Your balance is insufficient!");
            //            }
            //            break;

            //        case 3:
            //            Console.Write("Mark the amount to be added: ");
            //            int addMoney = Convert.ToInt32(Console.ReadLine());

            //            balans += addMoney;
            //            Console.WriteLine($"{addMoney} AZN was added. New balance : {balans} AZN");

            //            break;

            //        case 4:
            //            Console.WriteLine("The operation is over. Thank you for choosing our bank");
            //            davamEt = false;
            //            break;

            //        default:
            //            Console.WriteLine("You made the wrong choice. Select a mode from 1-4 again:)))");
            //            break;


            //    }
            //}

            #endregion

            #region TASK Menu SYSTEM
            //int total = 0;
            //bool continue = true;

            //Console.WriteLine("\n Welcome to our restaurant");
            //Console.WriteLine("\n Choose a dish from the menu");
            //Console.WriteLine("\n 1 - Pizza (15 AZN)");
            //Console.WriteLine("\n 2 - Burger (20 AZN)");
            //Console.WriteLine("\n 3 - Salad (30 AZN)");
            //Console.WriteLine("\n 3 - Juice (40 AZN)");

            //while (continue)
            //{

            //    Console.Write("Make your choice:  ");

            //    int seçim = Convert.ToInt32(Console.ReadLine());


            //    switch (seçim)
            //    {


            //        case 1:
            //            total += 15;
            //            Console.WriteLine("Your choice is Pizza. The price is 15 AZN");

            //            break;
            //        case 2:
            //            total += 20;
            //            Console.WriteLine("Your choice is Burger. The price is 20 AZN");

            //            break;
            //        case 3:
            //            total += 35;
            //            Console.WriteLine("Salad of your choice. Price 35 AZN");

            //            break;
            //        case 4:
            //            total += 45;
            //            Console.WriteLine("Your choice is a drink. The price is 45 AZN");

            //            break;
            //        default:
            //            Console.WriteLine("Make the right choice ");
            //            break;

            //    }



            //    Console.WriteLine("Do you want to continue the order? ( yes / no):  ");
            //    string answer = Console.ReadLine().ToLower();

            //    if (answer == "no")
            //    {
            //       continue  = false;
            //    }

            //    Console.WriteLine($" Total Price : {total} AZN");
            //}
            #endregion

            #region Task Even-Odd numbers
            //Console.WriteLine("Check whether the given order is odd or even ");
            //Console.WriteLine("Enter an eded ");
            //double number = Convert.ToDouble(Console.ReadLine());

            //switch (number % 2)
            //{
            //    case 0:
            //        Console.WriteLine("The number written was the only number");
            //        break;
            //    case 1:
            //        Console.WriteLine("The number written was the only number");
            //        break;
            //}
            #endregion

            #region TASK SALARY POSITION
            //Console.WriteLine("Bir vezife adı qeyd edin: ");
            //Console.WriteLine("\n1- Menecer");
            //Console.WriteLine("\n2- Müellim");
            //Console.WriteLine("\n3- Mühendis");
            //Console.WriteLine("\n4- Programist");

            //Console.WriteLine("\nSeçiminizi edin");
            //string position = Console.ReadLine();    
            //switch (position)
            //{
            //    case "Menecer":
            //        Console.WriteLine("Menecer - maaş 1500"); 
            //        break;

            //    case "Müellim":
            //        Console.WriteLine("Müellim - maaş 2000"); 
            //        break;

            //    case "Mühendis":
            //        Console.WriteLine("Mühendis - maaş 2500"); 
            //        break;
            //    case "Programist":
            //        Console.WriteLine("Programist - maaş 3000");
            //        break;
            //}
            #endregion

            #region TASK MONTH SWITCH
            //Console.WriteLine("1-12 until added number : ");

            //int number =Convert.ToInt32(Console.ReadLine());

            //var result = number switch
            //{
            //    1=>"January",   
            //    2=>"February", 
            //    3=>"Martch",
            //    4=>"April",
            //    5=>"May",
            //    6=>"June",
            //    7=>"July",
            //    8=>"August",
            //    9=>"September",
            //    10=>"October",
            //    11 => "November",
            //    12 => "December"
            //};
            //Console.WriteLine(result);
            #endregion

            #region TASK Change Money

            //int total = 0;
            //bool davamEt = true;

            //while (davamEt)
            //{
            //    Console.WriteLine("1- USD ");
            //    Console.WriteLine("2- EUR");
            //    Console.WriteLine("3- TRL");


            //    Console.WriteLine("Choose a exchange rate");
            //    int number = Convert.ToInt32(Console.ReadLine());


            //    Console.WriteLine("Enter the amount you want to convert");
            //    double mebleg = Convert.ToDouble(Console.ReadLine());

            //    switch (number)
            //    {
            //        case 1:
            //            double usdToAzn = mebleg * 1.7;
            //            Console.WriteLine($" Your given USD :{mebleg} bill became {usdToAzn} AZN. ");
            //            break;
            //        case 2:
            //            double euroToAzn = mebleg * 2;
            //            Console.WriteLine($" The EUR :{mebleg} bill you gave has become {euroToAzn} AZN ");
            //            break;
            //        case 3:
            //            double trlToAzn = mebleg * 0.049;
            //            Console.WriteLine($" The TRL :{mebleg} receipt you gave was {trlToAzn} AZN ");
            //            break;
            //        default:
            //            Console.WriteLine("Add correct mode");
            //            break;
            //    }

            //    Console.WriteLine("Do you want to continue the activity ? (yes/no): ");
            //    string answer = Console.ReadLine().ToLower();

            //    if (answer == "no")
            //    {
            //        davamEt = false;
            //    }

            //}
            #endregion

            #region TASK Favorite Fruits
            //decimal total = 0;
            //bool @continue= true;


            //Console.WriteLine("1-Apple");
            //Console.WriteLine("2-PineApple");
            //Console.WriteLine("3-Quince");
            //Console.WriteLine("4-Nar");

            //while (@continue)
            //{
            //    Console.WriteLine("Choose your favorite fruite: ");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    switch (number) 
            //    {
            //        case 1:

            //            total += 15;
            //            Console.WriteLine("Your favorite name apple and apple's price 15 $: ");

            //            break;
            //        case 2:

            //            total += 26;
            //            Console.WriteLine("Your favorite name Pineapple and Pineapple's price 26 $ ");
            //            break;
            //        case 3:
            //            Console.WriteLine("Your favorite name Quince and Quince's price 54 $ ");
            //            total += 54;

            //            break;
            //        case 4:
            //            Console.WriteLine("Your favorite name Quince and Quince's price 78 $ ");
            //            total += 78;

            //            break;
            //    }
            //    Console.WriteLine("Are you sure to continue your shopping (yes / no ): ");
            //    string answer = Console.ReadLine().ToLower();

            //    if (answer == "no") 
            //    {
            //        @continue= false;
            //     };
            //    Console.WriteLine($" total price : {total} usd ");
            //};
            #endregion

            #region If-Else First TASK
            //Console.WriteLine("Bir reqem elave edin : ");
            //int number =Convert.ToInt32(Console.ReadLine());

            //if (number % 3 == 0 && number % 5 == 0)
            //{
            //    Console.WriteLine("Daxil olunan reqem ne 5 - e ne de 3- e bölünür ");
            //}
            //else if (number % 3 == 0) 
            //{
            //    Console.WriteLine("Daxil edilen reqem 3 e bölünür");
            //}
            //else if (number % 5 == 0)
            //{
            //    Console.WriteLine("Daxil edilen reqem 5 e bölünür");
            //}
            //else
            // {
            //    Console.WriteLine("Daxil olunan reqem ne 5 - e ne de 3- e bölünür");
            // }

            #endregion

            #region TASK Exam Result If Else
            //Console.WriteLine("Please add your result of exam  ");
            //int result = Convert.ToInt32(Console.ReadLine());

            //if (result == 90)
            //{
            //    Console.WriteLine("Excelent");
            //}
            //else if (result < 80 && result > 70)
            //{
            //    Console.WriteLine("Your result is good");
            //}
            //else if (result < 60 && result > 50)
            //{
            //    Console.WriteLine("Your result is bad");
            //}
            //else if (result < 50)
            //{
            //    Console.WriteLine("Its really bad please repeat your lessons");
            //}
            #endregion

            //double cube = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    //result += i*i*i;
            //    cube += i * i * i;
            //}
            //Console.WriteLine(cube);

            #region Percent PRICE TASK
            //Console.Write("Please ,you add the first price: ");
            //int price1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please , you add the second price: ");
            //int price2 = Convert.ToInt32(Console.ReadLine());

            //if (price1 + price2 > 200)
            //{
            //    Console.WriteLine(price1+ (price2 * 75 / 100));
            //}
            //else
            //{
            //    Console.WriteLine(price1 + price2);
            //}


            //Console.Write("Please ,you add the first price: ");
            //int price1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please , you add the second price: ");
            //int price2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(price1 + price2 > 200 ? price1 + (price2 * 75 / 100) : (price1 + price2));

            #endregion

            #region TASK CHECK YOUR PASSWORD AND Name 
            //Console.Write("Please , write your name: ");
            //string name = Console.ReadLine();

            //Console.Write("Please, write your password: ");
            //string password = Console.ReadLine();

            //if (password == "123456" && name == "Gencay")
            //    Console.WriteLine("your entry is succesful");
            //else 
            //    Console.WriteLine("Your entry is foult");/// If...Else


            /*  Console.WriteLine(password == "123456" && name == "Gencay"? "your entry is succesful": "Your entry is foult");*////Ternary Patterns


            /// Property Pattern
            //People person = new People()
            //{
            //    Name = "Gencay",
            //    Password = "123456"
            //};
            //string result = person.Name switch
            //{
            //    "Gencay" => "123456",
            //    _ => "0"
            //};
            //Console.WriteLine(result);


            #endregion

            #region TASK
            //int digit =int.Parse(Console.ReadLine());

            //int one = digit / 100;
            //int two = digit / 10;
            //int end = digit % 10;
            //Console.WriteLine(one);
            //Console.WriteLine(end);
            //Console.WriteLine(two);
            #endregion

            #region TASK Hackerrank 
            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(number % 3 == 0 && number % 5 == 0 ? "FizzBuzz" :
            //                 (number % 3 == 0 ? "Fizz" :
            //
            //   (number % 5 == 0 ? "Buzz" : number)));
            #endregion

            #region Inside Variables If...Else Gencay
            ///// Daxil edilən rəqəmin negatif və ya pozitif olduguna dair bir uygulama yazın 
            //int number =int.Parse(Console.ReadLine());

            // string message = "";/// Burada global olaraq tanınmış bir dəyişkən , içəridən gələn dəyişkən 
            // ///ona mənimsədilir və hər hansı bir scope da da göndərilə bilər (152 video)
            // ///yəni message dəyişkəninə scope un hər yerində erişile bilirlilik əldə etmiş oldu . Bu məntiqə əsasən Dependency İnjection da da rast gəlinir .


            // if (number > 0)
            // {
            //     //Console.WriteLine("the written number is positive");
            //     message = "Positive";
            // }
            // else
            // {
            //     //Console.WriteLine("the written number is negative");
            //     message = "Negative";
            // }
            // Console.WriteLine(message);

            #endregion

            #region Type Pattern C# 7.0
            //object a = 123;
            //if (a is int b)
            //{
            //    Console.WriteLine(b);
            //}
            //else if (a is string d) 
            //{
            //    Console.WriteLine(d);
            //};
            #endregion

            #region Constant Pattern C# 7.0
            //object a = "Naila";
            //if(a is "Naila")
            //{
            //    Console.WriteLine("The written name is Naila ");
            //}
            //else if(a is "nnnnnn")
            //{
            //    Console.WriteLine("The written name is nnnnnn"); 
            //}
            ///// iki üsulla yaaza bilərik həm birinci həm də ikinci üsulla da yaza bilərik ikinci üsul bizə bool dəyər qaytaracaq 

            //int b = 123;
            //Console.WriteLine(b is 123);
            #endregion

            #region Var Pattern C# 7.0
            //object a = "Naile";
            //if(a is var b)
            //    Console.WriteLine(b);

            //object a = "Vafa";
            //Console.WriteLine(a is var b ? b : (a is var d?d:"Default value"));///Ternary operation
            #endregion

            #region Relational Pattern C# 9.0 SWITCH > <....
            //int number = 123;
            //var result = number switch
            //{
            //   > 120=>" The wrtitten number is high level",
            //   < 120=>"The written number is low level"
            //};
            //Console.WriteLine(result);
            /// Normal qaydalara əsasən switch ancaq bərabərlik halını yoxlayırdı indi isə c# 9.0 ilə gələn yeniliyə əsasən 
            /// artıq böyükdür kiçikdi hallarını da yoxlayacaq musahibə suali
            #endregion

            #region Logical Pattern C# 9.0 SWITCH Or Not And ....
            //int number = 111;
            //var result = number switch
            //{
            //    > 100 and < 112 => " 100 dən böyük 112 dən kiçik ",
            //    < 50 or < 100 and 60 => "50 dən böyük və ya 100 dən kiçik və 60 a bərabərdi ",
            //    not 50 => "50 deyil "

            //};
            //Console.WriteLine(  result );
            #endregion

            #region Try-Catch Block  1
            //try
            //{
            //    Console.WriteLine("Enter your first number ");
            //    int number1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter your second number");
            //    int number2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Toplam :" + (number1 + number2));
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Please enter number ");
            //}

            #endregion

            #region Try- Catch Block 2
            ///Çalışdığımız qədər bizə lazım olan kodları try blokunun daxilinə yazmaq lazımdı əks halda daha cox maliyəyə səbəb ola bilər 
            //Console.WriteLine("Please enter first number : ");
            //int number1=0, number2 = 0;
            //try
            //{
            //    number1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Please eneter second number: ");
            //    number2 = int.Parse(Console.ReadLine());    
            //}
            //catch 
            //{
            //    Console.WriteLine("Please enter true object");
            //}
            //Console.WriteLine("Total: " + ( number1 + number2));

            #endregion

            #region Try- CATCH Block 3
            //try
            //{
            //    object obj = null;
            //    obj.ToString();

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Mesaj: " + e.Message);
            //}

            //try
            //{
            //    //int a = 0, b = 111;
            //    //int result = b/a;

            //    int.Parse("Naila");
            //}
            //catch(Exception ex)  
            //{
            //    Console.WriteLine("Mesaj :" + ex.Message);
            //}
            #endregion

            #region For Example Task  ... 
            //for (int i =10;i>0; i-=2)
            //  {

            //      Console.WriteLine(i);

            //  }
            #endregion


            #region For Factorial- Task
            //Console.WriteLine(  "Please enter number " );
            //int number =Convert.ToInt32( Console.ReadLine() );
            //int fact = 1;

            //if (number == 0)
            //{
            //    fact = 1;
            //}
            //else
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        fact *= i;
            //    }
            //}
            //Console.WriteLine($"Result : {fact}");
            #endregion

            #region Find the even numbers:
            /// 1 - dən 100 - ə qədər olan bütün cüt rəqəmləri çap et.
            //for (int i = 0; i <= 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Add the odd numbers:
            ///  1 - dən 50 - yə qədər olan bütün tək rəqəmlərin cəmini hesabl
            //int sum = 0;
            //for (int i = 1; i <= 50; i += 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("Toplam deyer " + sum );
            #endregion

            #region Square the numbers in the array:
            //int[] numbers = { 1, 2, 3 ,4,5};

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int result = numbers[i]* numbers[i];
            //    Console.WriteLine($"Verilmiş massivin ededi:  {numbers[i]} ,kvadratı : {result}");
            //}
            #endregion

            #region FizzBuzz
            //int i =Convert.ToInt32(Console.ReadLine());
            //for (; i < 30; i++)
            //{
            //    Console.WriteLine(
            //    i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" :
            //    i % 3 == 0 ? "Fizz" :
            //    i % 5 == 0 ? "Buzz" :
            //    i.ToString());
            //}

            #endregion

            #region  Find the square of even numbers

            //Verilən massivdəki hər bir cüt rəqəmin kvadratını tapın və çap edin.
            //Massiv: { 1, 2, 3, 4, 5, 6, 7, 8, 9}
            //Çıxış: 4, 16, 36, 64
            //(Əgər element cüt rəqəmdirsə, onun kvadratını çap edin.)

            //int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        int kvadrat = numbers[i] * numbers[i];
            //        Console.WriteLine($"Tapılan cüt eded {numbers[i]} kvadratı{kvadrat}");
            //    }
            //}
            #endregion

            #region Find the min and max digits in the input
            //Verilən bir massivdəki minimum və maksimum elementləri tapın.
            //Massiv: { 8, 3, 5, 2, 10, 7, 6}
            //Çıxış: Min: 2, Max: 10

            //int[] numbers = { 8, 3, 5, 2, 10, 7, 6 };
            //int min = numbers[0];
            //int max = numbers[0];

            //for (int i = 0; i < numbers.Length; i++) 
            //{ 
            //    if (numbers[i] < min)
            //        min = numbers[i];

            //    else if (numbers[i] > max)
            //        max = numbers[i];
            //}
            //Console.WriteLine($" masivvdeki minimum reqem :{min} ve max reqem :{max}");

            #endregion

            #region Find the factorial of each number
            //Console.WriteLine("Please enter your favorite number :");
            //int number =Convert.ToInt32(Console.ReadLine());
            //int fact = 1;

            //if (number == 0)
            //{
            //    fact = 1;
            //}
            //else 
            //{
            //    for (int i = 1; i <=number; i++)
            //  {
            //        fact *= i;
            //   }
            //}

            //Console.WriteLine($"The writen numbers by {fact}");
            #endregion

            #region Write the reverse order of the array
            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //for (int i = numbers.Length-1; i>=0; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.Write("Please enter your name: ");
            // string name = Console.ReadLine();

            //Console.WriteLine("Changed name: ");
            //for (int i= name.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(name[i]);
            //}



            #endregion

            #region Find prime numbers in an array
            //int[] numbers = { 2, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //  bool davamEt =true;

            //    for (int j = 2; numbers[i] >j; j++)
            //    {
            //        if (numbers[i] % j == 0)
            //        {
            //            davamEt = false;
            //            break;
            //        }
            //    }

            //   if(davamEt && numbers[i] >1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion

            #region Reverse spelling of input name ....
            //Console.WriteLine("PLease enter your favorite name : ");
            //string name = Console.ReadLine();


            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(name[i]);
            //}
            #endregion

            #region Sum of numbers from 1 to N:
            //int result =0;
            //for (int i = 0; i <=50; i++) 
            //{
            //    result += i;
            //}
            //Console.WriteLine(result);
            #endregion

            #region Print in reverse direction:
            //Console.Write("Please enter start number: ");
            //int start = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter final number: ");
            //int final = Convert.ToInt32(Console.ReadLine());


            //    for (int i = start; i >= final; i--)
            //    {
            //        Console.WriteLine(i);
            //    }


            #endregion

            #region 1və 40 arasındakı cüt rəqəmlərin cəmi
            //int result = 0; 
            //for (int i = 0; i <=40; i++) 
            //{
            //    if (i % 2 == 0)

            //        result += i;

            //}
            //Console.WriteLine("Result: " + result);
            #endregion

            #region Rəqəmlərin fərqi
            //Console.WriteLine("compare the first and fourth digits of a four-digit number:");
            //int number =Convert.ToInt32(Console.ReadLine());

            //int firstDigit= number/1000;
            //int a= number/100;
            //int secondDigit = a%10;
            //int b= number%100;
            //int thirdDigit=b/10;
            //int fourthDigit= number%10;

            //Console.WriteLine(firstDigit);
            //Console.WriteLine(secondDigit);
            //Console.WriteLine(thirdDigit);
            //Console.WriteLine(fourthDigit);


            //Console.WriteLine(firstDigit > secondDigit ? "First number high from second" :
            //                  secondDigit > firstDigit ? "Second number high from first" :
            //                  number.ToString());
            #endregion


            #region Find the maximum and minimum numbers among N numbers entered. Print the maximum and minimum numbers and the numerical average of the entered numbers to the screen.
            //Console.Write("Neçə rəqəm əlavə etmək istəyirsiniz :");
            //int n =Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Birinci reqemi daxil edin:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //int max = num;
            //int min =num;
            //int total = num;

            //for (int i = 1; i < n; i++)
            //{
            //    Console.WriteLine($"Enter numbers:{i+1}");
            //    num = Convert.ToInt32(Console.ReadLine());

            //    if (num < max)
            //    {
            //        max = num;
            //    }
            //    else if (num > min)
            //    {
            //        min = num;
            //    }
            //    total = max + min;

            //}
            //  int avr = total / n;
            //Console.WriteLine("min: "+ min);
            //Console.WriteLine("max: "+ max);
            //Console.WriteLine("avarage :" +avr);
            //
            #endregion

            #region Sadə ədədləri tapın 

            //for (int i = 2; i <= 100; i++)
            //{
            //    bool davamet = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            davamet = false;
            //            break;
            //        }
            //    }
            //  if (davamet)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 2; i <= 100; i++)
            //{
            //    bool davamet = true; // Əvvəlcə sadə olduğunu fərz edirik
            //    for (int j = 2; j < i; j++) // j ilə bölünmə yoxlanır
            //    {
            //        if (i % j == 0) // Əgər tam bölünmə varsa
            //        {
            //            davamet = false; // Sadə deyil
            //            break; // Dövrü dayandırırıq, daha yoxlamağa ehtiyac yoxdur
            //        }
            //    }
            //    if (davamet) // Əgər sadədirsə
            //    {
            //        Console.WriteLine(i); // Sadə ədədi çap edir
            //    }
            //}
            #endregion

            //Console.WriteLine("Please enter your number: ");
            //int number=Convert.ToInt32(Console.ReadLine());

            //int result =0;

            //for (int i = 0; i < number; i++) 
            //{
            //    result += i;
            //}

            //Console.WriteLine(result);

            //Console.WriteLine("Please enter your favorite : ");
            //int number =Convert.ToInt32(Console.ReadLine());

            //int result = 0;

            //for (int i = 1; i < number; i++) 
            //{

            //    result = i*number;

            //    Console.WriteLine($"Daxil olunan eded : {number}  hasil : {result}");
            //}

            #region Collect the numbers
            //Console.WriteLine("Please enter your favorite number : ");
            //int number =Convert.ToInt32(Console.ReadLine());

            //int result = 0;
            //int sum =0; 
            //while(number > 0) 
            //{
            //    result = number % 10;
            //    sum += result;
            //    number /= 10;   
            //}

            //Console.WriteLine(sum);
            #endregion

            #region Reverse the input word
            //Console.Write("Enter your word : ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Change word: ");
            //for (int i = name.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(name[i]);
            //}
            #endregion

            #region Simple Calculator Switch Case Expression ///
            //  Console.Write("Please enter first number : ");
            //  int FirstDigit =Convert.ToInt32(Console.ReadLine());

            //  Console.Write("Please enter second number : ");
            //  int SecondDigit =Convert.ToInt32(Console.ReadLine());

            //  Console.Write("Enter operation symbols +,-,*,/: ");
            //  char symbols=Convert.ToChar(Console.ReadLine());

            //var result  =  symbols switch
            //  {
            //       '+'=>FirstDigit+SecondDigit,

            //       '-'=> FirstDigit - SecondDigit,

            //       '*'=> FirstDigit * SecondDigit,

            //       '/'=> FirstDigit / SecondDigit
            //  };
            //Console.WriteLine(result);
            #endregion

            #region Random rəqəmin tapilması 
            //Console.Write("Please enter your random number:  ");
            //int randomNumber = Convert.ToInt32(Console.ReadLine());

            //int number = 50;

            //while (true)
            //{
            //    if (randomNumber < 100 && number == randomNumber)
            //        Console.WriteLine("Congrulation !!!!!!");
            //    else
            //        Console.WriteLine("please enter true number");
            //        randomNumber= Convert.ToInt32(Console.ReadLine());

            //}
            #endregion


            #region Multiply the number of digits entered by the user by 5 and print the answer on the screen.
            //Console.WriteLine("Please enter yourr number : ");
            //int numbers = Convert.ToInt32(Console.ReadLine());

            //int result = numbers;
            //int a = 0; int b = 0;

            //while (numbers > 0)
            //{

            //    b = numbers % 10;
            //    numbers /= 10;
            //    a++;

            //}
            //for (int i = 0; i < a; i++)
            //{
            //    result *=5;
            //}
            //Console.WriteLine(result);
            #endregion

            #region Massivdəki təkrarlanan elementləri göstər 
            //int[] arr = { 1, 2, 3, 5, 6, 8, 3, 99, 45, 22, 1, 108, 99 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[j] == arr[i])
            //        {
            //           Console.WriteLine(arr[i]); 

            //            break;
            //        }
            //    }   
            //}


            #endregion

            #region  İstifadəçi daxil etdiyi mətndə sözlərin sayını tapın
            //Console.WriteLine("please enter your favorite word: ");
            //string sentences = Console.ReadLine();

            //int count = 0;
            //bool insideWord = false;
            //for (int i = 0; i < sentences.Length; i++)
            //{

            //    if (sentences[i] != ' '&&!insideWord)
            //    {
            //        count++;
            //        insideWord = true;
            //    }
            //    else if (sentences[i] == ' ')
            //    {
            //        insideWord =false;
            //    }
            //}
            //Console.WriteLine($"daxil edilen sözün sayı: {count}");

            #endregion

            #region Get a word and letter from the user. If the entered letter starts with the entered word, write 1 on the screen, otherwise 0.
            //Console.WriteLine("Zehmet olmasa söz elave edin : ");
            //string word= Console.ReadLine();

            //Console.WriteLine("Zehmet olmasa herf elave edin : ");
            //char symbyol = Convert.ToChar(Console.ReadLine());

            //for (int i = 0; i < word.Length;i++ )
            //{

            //}

            //if (word[0] == symbyol)
            //{
            //    Console.WriteLine($"{1}");
            //}
            //else if (word[0] != symbyol)
            //{
            //    Console.WriteLine($"{0}");
            //}
            #endregion

            #region Fakorial

            //Console.WriteLine("Please enter number : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int result = 1;

            //for (int i = 1; i <= number; i++)
            //{
            //    result *= i;
            //}
            //Console.WriteLine(result);

            //Console.WriteLine("Please enter your number : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int result = 1;

            //for (int i = number; i >= 1; i--)
            //{
            //    result *= i;
            //}
            //Console.WriteLine(result);
            #endregion

            #region Count in sentences
            //Console.WriteLine("Please enter some sentences : ");
            //string sentences = Console.ReadLine();

            //bool insideWord = false;

            //int count = 0;

            //for (int i = 0; i < sentences.Length; i++)
            //{


            //    if (sentences[i] != ' ' && !insideWord)
            //    {
            //        count++;
            //        insideWord = true;
            //    }
            //    else if (sentences[i]==' ')
            //    {
            //        insideWord = false;
            //    }
            //}
            //Console.WriteLine($"Daxil edilen cümledeki söz sayı: {count}");

            #endregion

            #region Control Name and Password
            //console.writeline( "please enter your name : ");
            //string name = console.readline();

            //int count = 0;

            //bool inside = false;
            //while (count <3) 
            //{
            //    console.writeline("please enter your password: ");
            //    string passwordinput = console.readline();

            //    if (!int.tryparse(passwordinput, out int password))
            //    {
            //        console.writeline("invalid password format. please enter a numeric password.");
            //        continue; 
            //    }
            //    if (name == "naila" && password == 26102001)
            //    {
            //        console.writeline("congrats!!! your enter is lucky)))");
            //        inside = true;
            //        break;
            //    }
            //    else
            //        count++;
            //    if (count ==3)
            //    {
            //        console.writeline("your access is blocked after 3 failed attempts.");
            //    }

            //}
            #endregion




            #region WhILE BASIC EXAMPLE....
            //int i=1; 

            //while (i<=10)
            //{
            //    i++;

            //    Console.WriteLine("Hello World");
            //}


            //Console.Write("Please enter your number : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //while (number >=0)
            //{
            //    Console.WriteLine(number);
            //    number--;

            //}

            //int i = 0;
            //int result=0;
            //while (i <=100)
            //{
            //    result += i;
            //    i += 2;
            //}
            //Console.WriteLine(result);

            #endregion

            #region the square of the number....

            //Console.WriteLine("Please enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <=10; i++)
            //{
            //   int result = number * i;
            //    Console.WriteLine($"enter number: {number} result: {result}");
            //}

            ///Factorial 
            //Console.Write("Enter a number : ");
            //int number =Convert.ToInt32(Console.ReadLine());

            //int fact = 1;

            //for (int i = 1; i <=number; i++)
            //{
            //    fact *= i;
            //}
            //Console.WriteLine($"Enter olunmuş reqem: {number}, factorial : {fact}");
            #endregion

            #region To REVERSE ....
            //Console.WriteLine("Plsease enter your favorite word : ");
            //string word=Console.ReadLine();

            //for (int i = word.Length -1; i >=0; i--)
            //{
            //    Console.WriteLine(word [i]);
            //}

            //string text = "Codelandia";

            //Console.WriteLine("Çevrilmiş söz : ");
            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(text[i]);
            //}
            #endregion

            #region Mobile phone number provided. What numbers in this number determine if it is not.

            // Console.Write("Please eneter a number : ");
            //string PhoneNumber=Console.ReadLine();


            //for (int i = 0; i < PhoneNumber.Length; i++)
            //{
            //    int count = 1;
            //    bool isDuplicate = false;
            //    for (int j = i+1; j < PhoneNumber.Length; j++)
            //    {
            //        if (PhoneNumber[i] == PhoneNumber[j])
            //        {
            //            count++;
            //            isDuplicate = true;
            //        }
            //    }

            //    if (isDuplicate) {
            //        Console.WriteLine($"Dublicate digit : {PhoneNumber[i]} dublicate count {count}");
            //    }
            //}
            #endregion

            #region 

            //object[] arr = { 1, 2, 4, 6, "N", 8, "y", "B", 9 };
            //char ch = Convert.ToChar(Console.ReadLine());

            //if (ch >= 65 && ch <= 90 || ch >= 97 && ch <= 122)
            //{
            //    bool found = false;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] is string) {

            //            string str = (string)arr[i];  

            //            if (str.Length == 1 && str[0] == ch)
            //            {
            //                Console.WriteLine(ch);
            //                 found = false;
            //                break;  
            //            }
            //        }

            //    }
            //    if (!found)
            //    {
            //        Console.WriteLine("Herf tapılmadı");
            //    }

            //}

            #endregion

            #region Choose string
            //object[] arr = { 1, 2, 4, 6, "N", 8, "y", "B", 9 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] is string)
            //    {
            //        string s = (string)arr[i];

            //        if (s.Length == 1)
            //        {
            //            Console.WriteLine(arr[i]);
            //        }

            //    }
            //}
            #endregion


            #region Verilmiş massivdən təkrarlanan elementləri silin. 

            //int[] arr = { 1, 2, 3, 5, 6, 8, 3, 99, 45, 22, 1, 108, 99 };//1,3,99

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    bool isContinue=false;

            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])

            //          isContinue = true;

            //    }
            //    if (!isContinue)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}
            #endregion

            #region Reverse number
            //Console.WriteLine("Please enter your number : ");
            //int number =Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //while (number > 0)
            //{
            //    int lastDigit =number % 10;
            //    result += lastDigit;
            //    number /= 10;
            //}
            //Console.WriteLine(result);
            #endregion

            #region Rəqəmlərinin cəmi....
            //Console.WriteLine("Please enter a number :");
            //int number =Convert.ToInt32(Console.ReadLine());

            //while (number > 0)
            //{
            //    int digit = number % 10;
            //    number /= 10;
            //    Console.Write(digit);

            //}
            #endregion

            #region MyRegion
            //int i = 0, result = 0;
            //while (i<=100)
            //{
            //    if (i % 2 == 1)
            //        result += i;
            //    i++;

            //}
            //Console.WriteLine(result);
            #endregion

            #region While With Factorial....
            //Console.WriteLine("Please enter number: ");
            //int number =Convert.ToInt32(Console.ReadLine());

            //int result = 1,fact=1;

            //while (number > 0)
            //{

            //  fact*=number-- ;// bunu o zaman yaza bilərik ki if şərti verilmədikdə 
            //    //number--;

            //}
            //Console.WriteLine(fact);

            #endregion

            #region While DateTime Now...

            //while (true)
            //{
            //    if(DateTime.Now.Second%5==0)
            //        Console.WriteLine(DateTime.Now);
            //    }
            #endregion

            #region
            //for (int i = 0; i < 5; i++) {
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 2; k++)
            //        {
            //        }
            //    }
            //   }
            #endregion

            #region Intervyu question
            //int[] arr = { 1, 2, 9, 3, 7 , 6, 5, 9 };
            //int maxUnique = int.MinValue;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int count = 0;

            //    // Təkrarları yoxlayırıq:
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //            count++;
            //    }

            //    // Əgər yalnız 1 dəfə təkrarlanıbsa və mövcud ən böyükdən böyükdürsə:
            //    if (count == 1 && arr[i] > maxUnique)
            //    {
            //        maxUnique = arr[i];
            //    }
            //}

            //Console.WriteLine("Ən böyük unique rəqəm: " + maxUnique);

            #endregion

            #region Vurma Cədvəli....

            //Console.WriteLine("1-10 arası bir reqem daxil edin :");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int total = 1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    total = number * i;

            //    Console.WriteLine(total + "=" + number + "*" + i);
            //}

            //for (int i = 1; i <= 10; i++)
            //{

            //    for (int j = 1; j <= 10; j++)
            //    {

            //        Console.WriteLine($"{i}*{j}={i * j}");
            //    }
            //}

            #endregion

            #region Numbers Avarage

            //Console.Write("How much digits do you need to enter: ");
            //int digits=Convert.ToInt32(Console.ReadLine());

            //double total = 0;

            //for (int i = 0; i < digits; i++)
            //{
            //    Console.Write($"Please enter number {i + 1}: ");
            //    double number = Convert.ToInt32(Console.ReadLine());

            //    total += number;               
            //}
            //double avarage = (double)total / digits;

            //Console.WriteLine($"Avarage : {avarage}");

            #endregion

            #region Repeat Task ....
            //Console.WriteLine("Please enter your favourite word : ");
            //string  word=Console.ReadLine();

            //for (int i = word.Length - 1; i >=0; i--)
            //{
            //    Console.Write( word[i]);
            //}
            //Console.WriteLine(); 
            #endregion

            #region Istənilən iki ədəd arasındakı ədədlərin ədədi ortası
            //Console.Write("Please enter first number: ");
            //int firstNum=Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter second number: ");
            //int secondNum=Convert.ToInt32(Console.ReadLine());

            //int sum = 0,avr=0,count=0;

            //Console.Write("Iki eded arasında olan ededlerin ededi ortası : ");
            //for (int i=firstNum;i<=secondNum; i++)
            //{
            //    sum += i;
            //    count++;
            //    avr=sum/count;
            //}
            //Console.WriteLine(avr);
            #endregion


            //List<Action> actions = new List<Action>();
            //for (int i = 0; i <= 3; i++)
            //{

            //    actions.Add(() =>{Console.WriteLine();});
            //}

            //foreach (var action in actions)
            //{
            //    action();
            //}
            #region Repeat task .....

            //Console.WriteLine("Please enter number : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int total = 0, a = 0;

            //while (number > 0)
            //{
            //    a = number % 10;
            //    total += a;
            //    number /= 10;
            //}
            //Console.WriteLine("Sum of the digit " + total);

            #endregion




            #region UNIQUE olmayan obyektlər ....
            //int[] arr = { 1, 2, 3 ,9,4,5,6,7,8,9};



            //   for (int i = 0; i < arr.Length; i++)
            //   {
            //       bool IsUnique = true;

            //       for (int j = 0; j < arr.Length; j++)
            //       {
            //           if (i!=j&&arr[i] == arr[j])
            //           {
            //               IsUnique = false;
            //               break;
            //           }

            //       }

            //       if (IsUnique)
            //       {
            //           Console.WriteLine(arr[i]);
            //       }
            //   }

            #endregion

            //Console.WriteLine("Please enter number : ");
            //string number =Console.ReadLine();

            //bool InCreasing = true;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] < number[i] - i)
            //    {
            //        InCreasing = false;
            //        break;
            //    }
            //}
            //if (InCreasing)
            //{
            //    Console.WriteLine("Artan sıradadı");

            //}
            //else 
            //{
            //    Console.WriteLine("Artan sırada deyil");
            //}

            //Console.WriteLine( "Please enter a number : ");
            //string number = Console.ReadLine();

            //List<string> list = new List<string>();

            //foreach (Char item in number)
            //{
            //    list.Add(item.ToString());
            //}
            //foreach (string item in list)
            //{
            //    Console.WriteLine("Reqemler" + " ");
            //}


            //for (int i = 0; i < number.Length; i++)
            //{
            //    bool Increasing = true;
            //    for (int j = i + 1; j < number.Length; j++)
            //    {
            //        if (number[i] > number[j])
            //        {
            //            Console.WriteLine("Artan sıra ile düzülmüşdür" + number[i]);
            //        }
            //        else if (number[i] < number[j])

            //        {
            //            Console.WriteLine("Azalan sıra ilə düzülmüşdür");
            //            //Increasing = false; break;
            //        }

            //    }

            //}

            #region the sum of the digits of the added number
            //Console.WriteLine( "Please enter integer number : ");
            //int number =Convert.ToInt32(Console.ReadLine());
            //int total = 0;

            //while (number > 0)
            //{
            //    total += number % 10;
            //    number /= 10;
            //}
            //Console.WriteLine("the sum of the digits of the added number :  "+total);


            #endregion

            #region  Sorted number in descending order

            //Console.WriteLine("Please enter integer number : ");
            //string number = Console.ReadLine();
            //char[] digits = number.ToCharArray();

            //for (int i = 0; i < digits.Length - 1; i++)
            //{
            //    for (int j = 0; j < digits.Length - i - 1; j++)
            //    {
            //        if (digits[j] < digits[j + 1])
            //        {
            //            (digits[j], digits[j + 1]) = (digits[j + 1], digits[j]);//tuple swam c# 7 ilə gəlib

            //        }
            //    }

            //}
            //Console.WriteLine("Sorted number in descending order:" + new string(digits));

            #endregion

            #region
            //Console.Write("How many digits do you want to enter : ");
            //int digit = Convert.ToInt32(Console.ReadLine());

            //if (digit <= 0)
            //{
            //    Console.WriteLine("The number of digits must be positive.");
            //    return;
            //}

            //Console.WriteLine("Please enter first number : ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());

            //int max = firstNumber;
            //int min = firstNumber;


            //for (int i = 0; i < digit; i++)
            //{
            //    Console.WriteLine($"Please enter number : {i + 1}");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    if (number > max)
            //    {
            //        max = number;
            //    }

            //    if (number < min)
            //    {
            //        min = number;
            //    }

            //}
            //Console.WriteLine("Max number" + max);
            //Console.WriteLine("Min number" + min);
            //int difference = max - min;
            //Console.WriteLine($"Max and min of numbers difference:  {difference}");

            #endregion


            #region FizzBuzz Ternaryy.....
            //Console.WriteLine("Please enter integer number : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= number; i++)
            //{
            //    Console.WriteLine(i % 3 == 0 && i % 5 == 0 ? "FizzBuzz" :
            //        i % 5 == 0 ? "Buzz" :
            //        i % 3 == 0 ? "Fizz" :
            //        i.ToString());
            //}
            #endregion

            #region  Fərqli Rəqəmlərin Sayı

            //Console.WriteLine("Please add ineteger number: ");
            //string input = Console.ReadLine();

            //bool[] digits=new bool[10];

            //int count = 0;

            // foreach (char c in input) { 
            //    if (!digits[c - '0'])
            //    {
            //        digits[c - '0'] = true; count++;
            //    }

            //}
            //Console.WriteLine($"How many digits have in this number {count}");

            //Console.WriteLine("Please enter integer number: ");
            //string input = Console.ReadLine();

            //HashSet<char> uniqeNumber = new HashSet<char>(input);
            //{
            //    Console.WriteLine($"Please ");
            //}


            //Console.Write("Verilmiş ədəd: ");
            //string input = Console.ReadLine(); // İstifadəçidən ədəd alırıq

            //HashSet<char> uniqueDigits = new HashSet<char>(input); // Təkrarlanan rəqəmləri silirik

            //Console.WriteLine($"Fərqli rəqəmlərin sayı: {uniqueDigits.Count} ({string.Join(", ", uniqueDigits)})");





            #endregion

            #region Max and Min number's difference

            //Console.Write("How many digits want to need : ");
            //int digits = Convert.ToInt32(Console.ReadLine());

            //if (digits <= 0)
            //{
            //    Console.WriteLine("Please enter positive digits");
            //    return;
            //}
            //Console.Write("Please  enter first number :");
            //int FirstNum = Convert.ToInt32(Console.ReadLine());

            //int max = FirstNum;
            //int min = FirstNum;

            //for (int i = 1; i < digits; i++)
            //{
            //    Console.Write($"Please enter numbeerr:{i + 1} ");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    if (number > max)
            //        max = number;
            //    if (number < min)
            //        min = number;
            //}
            //Console.WriteLine($"Max number{max}");
            //Console.WriteLine($"Min number{min}");
            //int difference = max - min;
            //Console.WriteLine($"Difference : {difference}");
            #endregion


            #region Repeat Taskss ...
            //Console.WriteLine("Please enter number: ");
            //int number=Convert.ToInt32(Console.ReadLine());

            //int fact = 1;

            //for (int i = 1; i <=number; i++) 
            //{
            //    fact *= i;
            //}
            //Console.WriteLine($"Facrial: {fact}");


            //Console.WriteLine("Please enter a integer number");
            //int number=Convert.ToInt32(Console.ReadLine());

            //int total = 0;

            //while (number > 0)
            //{
            //    total *= number % 10;
            //    number /= 10;
            //}
            //Console.WriteLine($"Reqemlerinin hasili: {total}");

            //Console.WriteLine("Please enter integer number: ");
            //int number =Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //{
            //    if (number % 1 == 0 && number % number == 0)
            //    {
            //        Console.WriteLine("Adding number is Asal's number");
            //    }
            //   }

            #endregion

            #region While Task
            //int number =1;  
            //while (number<=10)
            //{
            //    Console.WriteLine("Hello World");
            //    number++;
            //}

            //Console.Write("please enter integer number : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //while (number > 0)
            //{

            //    Console.WriteLine(number);
            //    number--;
            //}

            //int result = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        result += i;
            //    }


            //}
            //Console.WriteLine(result);


            //int result = 0, number = 1;
            //while (number <= 100)
            //{
            //    result += number;
            //    number += 2;

            //}
            //Console.WriteLine(result);

            //Console.WriteLine("Please enter integer number : ");
            //int number =Convert.ToInt32(Console.ReadLine());

            //int fact = 1;

            //while (number >0) 
            //{ 
            //    fact *= number--; 
            //  //number--;
            //}
            //Console.WriteLine(fact);

            //while (true) {
            //    if (DateTime.Now.Second % 5 == 0)
            //    {
            //        Console.WriteLine(DateTime.Now);
            //    }

            //bool cycle = true;

            //for (; cycle; ) 
            //{ 
            //    if (true)

            //        cycle = !cycle;// sonlu dövr
            //}
            #endregion

            #region
            //Console.WriteLine("Please enter integer number ");
            //int number=Convert.ToInt32(Console.ReadLine());
            //string numberstr = Convert.ToString(number);

            //int oddSum = 0;
            //int evenSum= 0;

            //foreach (int c in numberstr) 
            //{
            //    int digits = c - '0';

            //    if (digits % 2 == 0)
            //    {
            //        evenSum += digits;
            //    }
            //    else
            //    {
            //       oddSum += digits;
            //    }
            //}
            //Console.WriteLine($"Even summer : {evenSum}");
            //Console.WriteLine($"Odd summer : {oddSum}");

            //Console.WriteLine("Please enter integer number : ");
            //int number =Convert.ToInt32(Console.ReadLine());
            //string numberStr=Convert.ToString(number);

            //int sum = 1;

            //foreach(char c in numberStr)
            //{
            //    int digit = c - '0';
            //    sum *= digit;
            //}
            //Console.WriteLine($"Verilmiş ededin reqemlerin hasili: {sum}");

            //object[] obj = { "N", 1, 44, 6, "P", "I", 3,"L","A", 4, 8,"P" };

            //for (int i = 0; i < obj.Length; i++) 
            //{
            //    //if (obj[i] is int number )
            //    //{
            //    //    Console.WriteLine($"Choosing number: {number}");
            //    //}
            //    if (obj[i] is string word)
            //    {
            //        Console.WriteLine($"Choosing word: {word}");
            //    }
            //}


            #endregion

            #region Switch Expression PATTERN Matching'in Relation Pattern Növü....
            //int number = 345;
            //var result =number switch
            // {
            //     > 300 and < 346 =>"300 ededinden böyük 346 dan kiçikdi ",
            //     _ => "Şərtlərə uyğun deyil."
            // };
            //Console.WriteLine(result);
            #endregion


            #region Reverse Number
            //Console.WriteLine("Please enter integer numebr :");
            //string number =Console.ReadLine();

            //for (int i = number.Length-1; i >=0; i--)
            //{
            //    Console.WriteLine(number[i]);
            //}

            //Console.WriteLine("Please enter integer number : ");
            //string input =Console.ReadLine();

            //char[]digits =input.ToCharArray();

            //for (int i = 0; i < digits.Length-1; i++) 
            //{
            //    for (int j = 0; j < digits.Length - i - 1; j++)
            //    {
            //        if (digits[j] < digits[j+1])

            //            (digits[j], digits[j + 1]) =(digits[j+1], digits[j]);
            //    }
            //}
            //Console.WriteLine($"Inputing number reverse : {new string(digits)}");

            //Console.WriteLine("Please enter integer number : ");
            //int number =Convert.ToInt32(Console.ReadLine());
            //int total = 0;
            //while (number > 0)
            //{
            //    total += number % 10;
            //    number /= 10;
            //}
            //Console.WriteLine($"Total: {total}");

            //Console.WriteLine("Please enter number :");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int fact = 1;
            //for (int i = 1; i <=number; i++)
            //{
            //    fact *= i;

            //}
            //Console.WriteLine($"Factorial: {fact}");


            #endregion

            #region Sonsuz Dövr

            //bool IsContinue= false;

            //while (!IsContinue)
            //{
            //    if (true)
            //    {
            //        IsContinue = !IsContinue;
            //    }
            //}
            #endregion

            #region GençayYıldız  Task 

            #region iki ədədin toplanması
            // Console.WriteLine("Please enter first number : ");
            // int FirstNum=Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Please enter second number : ");
            // int SecondNum=Convert.ToInt32(Console.ReadLine());



            //int total =FirstNum+SecondNum;

            // Console.WriteLine($"total price {total}");
            #endregion

            #region iki ədədin kvadratları cəmi
            //try
            //{
            //    Console.WriteLine("Please enter integer number: ");
            //    int FirstNum = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Please enter second int number: ");
            //    int SecondNum = Convert.ToInt32(Console.ReadLine());

            //    int total=FirstNum*FirstNum + SecondNum*SecondNum;
            //    Console.WriteLine($"Total price : {total}");

            //}
            //catch
            //{

            //    Console.WriteLine("Please enter true input number :))) ");
            //}

            //Console.WriteLine("Please enter first and second number : ");
            //Console.WriteLine(Math.Pow(int.Parse(Console.ReadLine()),2) + Math.Pow(int.Parse(Console.ReadLine()),2)); 

            //Console.WriteLine("Please enter a number : ");
            //Console.WriteLine( Math.Pow(int.Parse(Console.ReadLine()),2 )+ Math.Pow(int.Parse(Console.ReadLine()),2));;

            #endregion

            #region  1-10 a qədər ədədlərin kubu....
            //int total = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    total = i * i * i;
            //    Console.WriteLine($"Total:{i}, {total}");
            //}
            //double total = 0;
            //int count = 1;
            //while (count<=10)
            //{
            //  total += Math.Pow(count, 3);
            //  count++;
            //}
            //Console.WriteLine("Result : "+ total);

            //int total = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    total += i * i * i;
            //}
            //Console.WriteLine($"Result : {total}");

            //double total = 0;

            //int count = 1;

            //while (true)
            //{
            //    //total += Math.Pow(count, 3);
            //    total += count * count * count;
            //    if (count == 10) break;
            //    count++;
            //}
            //Console.WriteLine("Result: " + total);

            #endregion

            #region Return example
            //for (int i = 0; i <100; i++)
            //{
            //    if (i == 22)
            //    {
            //        return;
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Istifadəçidən n sayda rəqəm al lakin "P" hərfi daxil olunana qədər verilən sayılar toplansın

            //int total = 0;
            // while (true)
            //{
            //    Console.WriteLine("Please enter number : ");
            //    string input= Console.ReadLine();
            //    if (input == "P")
            //    {
            //        Console.WriteLine("Result" + total);
            //        break;
            //    }
            //    else
            //    {
            //        total += int.Parse(input);
            //    }
            //}

            #endregion

            #region İstifadəçidən sonsuz sayda ədəd alınır lakin 37 daxil olunanda proqram sonlanılır .

            //while (true) 
            //{
            //    Console.WriteLine("Please enter integer number : ");
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    if (number % 37==0)
            //    {
            //        Console.WriteLine("The algorithm has been completed.");
            //        break;
            //    }

            //}

            #endregion

            #region Kurs Task .....

            //Console.WriteLine("Please enter phone number : ");
            //string input = Console.ReadLine();

            //char[] allDigits = "0123456789".ToCharArray();

            //for (int i = 0; i < allDigits.Length; i++)
            //{
            //    bool IsContinue = false;

            //    for (int j = 0; j < input.Length; j++)
            //    {
            //        if (allDigits[i] == input[j])
            //        {
            //            IsContinue = true;
            //            break;
            //        }
            //    }
            //    if (!IsContinue)
            //    {
            //        Console.Write(allDigits[i] + " ");
            //    }
            //}
            #endregion

            #region Sonsuz sayda daxil olunan ədədlərin müsbət olanlarını vurmaq və t hərfi daxil olunanda nəticəsini ekrana yazdırmaq 

            int total = 1;
            while (true)
            {
                Console.WriteLine("Please enter positive number : ");
                string Input = Console.ReadLine();

                if (Input == "t")
                {
                    Console.WriteLine($"Total : {total}");
                    break;
                }
                else
                {
                    int property = int.Parse(Input);
                    if (property < 0)
                        continue;

                    total *= property;
                }
            }
            #endregion




        }


        #region Switch Property Patterns ardı
        //class Students
        //{
        //    public string Name { get; set; }
        //    public string LastName { get; set; }
        //    public int Age { get; set; }

        //    public  void Deconstruct( out string name , out string lastName)
        //    {
        //       name = Name;
        //        lastName = LastName;
        //    }
        //}
        #endregion

        #region Switch Property Patterns Part-2

        //class People
        //{
        //    public string Name { get; set; }
        //    public string Password { get; set; }

        //    public void Deconstruct(out string name, out string password)
        //    {
        //        name = Name;
        //        password = Password;

        //    }
        //}
        #endregion




    }
}
