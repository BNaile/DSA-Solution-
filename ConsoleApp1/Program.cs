using System.Collections.Concurrent;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");



            #region Ternary
            //bool medeniHal=true;
            //int a = 125;
            //Console.WriteLine(a==123?"Girişiniz ugurlu oldu..":"Girişiniz ugursuzdu...");


            //object obj = 123;
            //int a =(int)obj;
            //Console.WriteLine(obj);

            //Console.WriteLine("Please choose the number..");
            //int number =int.Parse(Console.ReadLine());
            //int a = 125;
            //Console.WriteLine(a == 123 ? "Girişiniz ugurlu oldu.." : "Girişiniz ugursuzdu...");


            #endregion

            #region Toplama Çıxma
            //Console.WriteLine("Please add your name ...");


            //object x = "Ahmet";
            //int? y = x as int?;
            //if (y != null)
            //    Console.WriteLine("Giriş ugurludu");
            //else
            //    Console.WriteLine("Giriş ugursuzdu");
            //Console.WriteLine(y);
            //int a = 4;
            //int b = a++;// ekranda  4// yaddaşda 5
            //int c = ++b;// ekranda 5// yaddaşda 6
            //Console.WriteLine(b);
            //Console.WriteLine(c);



            //int b = 6;
            //int c = b++;// ekranda 6 // yaddaşda 7 b=7 c=5 d=5
            //int d = --c;//  ekranda 5// yaddaşda 6 
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

            #region Cast Aperatoru
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
            //string name1 = a switch
            //{
            //    10 => "anam",
            //     11 => "atam",
            //      12 => "qardaşım",
            //       23 => "annecim"
            //};
            //Console.WriteLine(name1);
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
            //        name = "Parviz";
            //        break;
            //    case (21,22):
            //        name = "Kamala";
            //        break;
            //}
            //Console.WriteLine(name);


            //int age = 22;
            //int age1 = 23;

            //string name = (age, age1) switch
            //{
            //    (22,23)=> "Naila",
            //    (24,25)=>"Parviz",
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

            //    //case "Ağalarov":
            //    //    salary = 200;
            //    //    break;

            //    { LastName: "Bayramov" } => 2690,
            //    { LastName: "Bayramova", Age: 24 } => 290,
            //    var x when x.Age==25 && x.LastName=="Bayramova" => 260,
            //    var x when x.Age==34 && x.LastName=="Dadaşova" => 2300,
            //    var x when x.Age==45 && x.LastName=="Hajılı" => 348,
            //    { LastName: "Dəstəgul" } when !true =>450,

            //};
            //Console.WriteLine(salary);
            #endregion

            #region Mixed IF..Else task
            //int i = 10;
            //if (i != 10)
            //{

            //    Console.WriteLine("i dəyəri 10 deyil");
            //}
            //else
            //{
            //    Console.WriteLine("i dəyəri 10 dur");
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
            //    Console.WriteLine("\n1-4 arasında bir reqem seç ");
            //    Console.WriteLine("\n1 Balansı yoxla");
            //    Console.WriteLine("\n2 Pul çıxar");
            //    Console.WriteLine("\n3 Pul yatır");
            //    Console.WriteLine("\n4 Çıxış ");
            //    Console.Write("Seçiminizi edin: ");

            //    int number = Convert.ToInt32(Console.ReadLine());


            //    switch (number)
            //    {
            //        case 1:
            //            Console.WriteLine($"Yerdə qalan balansınız {balans}");

            //            break;
            //        case 2:

            //            Console.Write("Çekilecek mebleği qeyd edin: ");
            //            int cekilenPul = Convert.ToInt32(Console.ReadLine());

            //            if (balans >= cekilenPul)
            //            {
            //                balans -= cekilenPul;
            //                Console.WriteLine($"{cekilenPul} AZN çıxarıldı. Yeni balans: {balans} AZN");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Balansınız kifayət deyil!");
            //            }
            //            break;

            //        case 3:
            //            Console.Write("Elave ediləcek mebleği qeyd edin: ");
            //            int addMoney = Convert.ToInt32(Console.ReadLine());

            //            balans += addMoney;
            //            Console.WriteLine($"{addMoney} AZN elave edildi .Yeni balans : {balans} AZN");

            //            break;

            //        case 4:
            //            Console.WriteLine("Emeliyyat bitdi . Bizim bankı seçdiyiniz üçün size Teşekkür edirik");
            //            davamEt = false;
            //            break;

            //        default:
            //            Console.WriteLine("Yalnış seçim etdiniz . Yenidən 1-4 aralığında reqem seçin :)))");
            //            break;


            //    }
            //}

            #endregion

            #region TASK Menyu SİSTEMİ
            //int total = 0;
            //bool davamEt = true;

            //Console.WriteLine("\nRestoranmıza xoş gelmisiniz");
            //Console.WriteLine("\nMenyudan bir yemek seçin");
            //Console.WriteLine("\n 1 - Pizza (15 AZN)");
            //Console.WriteLine("\n 2 - Burger (20 AZN)");
            //Console.WriteLine("\n 3 - Salat (30 AZN)");
            //Console.WriteLine("\n 3 - İçecek (40 AZN)");

            //while (davamEt)
            //{

            //    Console.Write("Seçiminizi edin :  ");

            //    int seçim = Convert.ToInt32(Console.ReadLine());


            //    switch (seçim)
            //    {


            //        case 1:
            //            total += 15;
            //            Console.WriteLine("Seçiminiz Pizza .Qiymeti 15 AZN");

            //            break;
            //        case 2:
            //            total += 20;
            //            Console.WriteLine("Seçiminiz Burger.Qiymeti 20 AZN");

            //            break;
            //        case 3:
            //            total += 35;
            //            Console.WriteLine("Seçiminiz Salat.Qiymeti 35 AZN");

            //            break;
            //        case 4:
            //            total += 45;
            //            Console.WriteLine("Seçiminiz Içeçek.Qiymeti 45 AZN");

            //            break;
            //        default:
            //            Console.WriteLine("Düzgün seçimi edin ");
            //            break;

            //    }



            //    Console.WriteLine("Sifarişi davam etdirmək istəyirsinizmi? ( beli / xeyr):  ");
            //    string answer = Console.ReadLine().ToLower();

            //    if (answer == "xeyr")
            //    {
            //        davamEt = false;
            //    }

            //    Console.WriteLine($" Ümumi qiymet : {total} AZN");
            //}
            #endregion

            #region Task Cüt-Tək ədədlər
            //Console.WriteLine("Verilmiş ededin tek ve ya cüt oldugunu yoxlayın ");
            //Console.WriteLine("Bir eded daxil edin ");
            //double number = Convert.ToDouble(Console.ReadLine());

            //switch (number % 2)
            //{
            //    case 0:
            //        Console.WriteLine("Yazdığınız reqem cüt reqemdi");
            //        break;
            //    case 1:
            //        Console.WriteLine("Yazılan reqem tek reqemdi");
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


            //    Console.WriteLine("Bir mezenne seçin");
            //    int number = Convert.ToInt32(Console.ReadLine());


            //    Console.WriteLine("Çevirmek istediyiniz meblegi daxil edin");
            //    double mebleg = Convert.ToDouble(Console.ReadLine());

            //    switch (number)
            //    {
            //        case 1:
            //            double usdToAzn = mebleg * 1.7;
            //            Console.WriteLine($" Verdiyiniz USD :{mebleg} eskinazı {usdToAzn} AZN oldu. ");
            //            break;
            //        case 2:
            //            double euroToAzn = mebleg * 2;
            //            Console.WriteLine($" Verdiyiniz EUR :{mebleg} eskinazı {euroToAzn} AZN oldu ");
            //            break;
            //        case 3:
            //            double trlToAzn = mebleg * 0.049;
            //            Console.WriteLine($" Verdiyiniz TRL :{mebleg} eskinazı {trlToAzn} AZN oldu ");
            //            break;
            //        default:
            //            Console.WriteLine("Doğru reqem elavə edin");
            //            break;
            //    }

            //    Console.WriteLine("mezenne fealiyyetini davam etdirmək isteyirisiniz mi ? (beli/xeyr): ");
            //    string answer = Console.ReadLine().ToLower();

            //    if (answer == "xeyr")
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

            #region Dəmirin Kursda Verdiyi TASK
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
            //Console.WriteLine(  "Bir eded daxil edin " );
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

            #region Cüt rəqəmləri tap:
            /// 1 - dən 100 - ə qədər olan bütün cüt rəqəmləri çap et.
            //for (int i = 0; i <= 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Tək rəqəmləri topla:
            ///  1 - dən 50 - yə qədər olan bütün tək rəqəmlərin cəmini hesabl
            //int sum = 0;
            //for (int i = 1; i <= 50; i += 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("Toplam deyer " + sum );
            #endregion

            #region Massivdəki rəqəmlərin kvadratı:
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

            #region  Çift rəqəmlərin kvadratını tap

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

            #region Girişdəki min və max rəqəmləri tap
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

            #region Hər rəqəmin faktorialını tap
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

            #region Massivin tərs qaydasını yazdır
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

            #region Massivdəki sadə ədədləri tap
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

            #region Daxil olunan adın tərsinə yazılması ....
            //Console.WriteLine("PLease enter your favorite name : ");
            //string name = Console.ReadLine();


            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(name[i]);
            //}
            #endregion

            #region 1-dən N-ə qədər rəqəmlərin cəmi:
            //int result =0;
            //for (int i = 0; i <=50; i++) 
            //{
            //    result += i;
            //}
            //Console.WriteLine(result);
            #endregion

            #region Əks istiqamətdə çap et:
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


            #region N sayda daxil edilən ədədlər içərisindən maksimum və minimum ədədlərin tapın. Ekrana maksimum və minimum ədədləri və daxil edilən ədədlərin ədədi ortasını çap edin.
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

            #region Rəqəmləri toplamaq
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

            #region Daxil edilmiş sözü tərsinə çevirmək
            //Console.Write("Enter your word : ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Change word: ");
            //for (int i = name.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(name[i]);
            //}
            #endregion

            #region Sadə Kalkulyator Swich Case Expression ///
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


            #region İstifadəçi daxil etdiyi ədədin rəqəmlərinin sayı qədər 5ə vurub cavabı ekrana yazdırın.
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
            #region İstifadəçidən bir söz və hərf alın. Əgər daxil etdiyi hərf daxil etdiyi sözlə başlayırsa ekrana 1 yazılsın əks halda 0.
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
