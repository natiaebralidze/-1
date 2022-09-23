
//შექმენით პროგრამა რომელიც:დაბეჭდავს კლავიატურიდან შემოტანილ ტექსტს.(სახელს და გვარს)

//Console.WriteLine("Please enter your name:");
//string namep =Console.ReadLine();
//Console.WriteLine("Please enter your surname:");
//string surname = Console.ReadLine();
//Console.WriteLine($"your name is {namep} {surname}");


//კლავიატურიდან შემოიტანს ორ რიცხვს და დაბეჭდავს მათ : ჯამს , სხვაობას, ნამრავლს, პირველი რიცხვის მეორეზე გაყოფის ნაშთს.

//Console.WriteLine("Enter first number");
//string first = Console.ReadLine();

//bool firstIsInt = int.TryParse(first, out int firstResult);

//if (!firstIsInt)
//{
//    Console.WriteLine($"{first} is not number");
//    firstResult = 100;
//}

//Console.WriteLine("Enter second number");
//string Second = Console.ReadLine();

//bool secondIsInt = int.TryParse(Second, out int secondResult);

//if (!secondIsInt)
//{
//    Console.WriteLine($"{Second}is not number");
//    secondResult = 100;
//}

//if (firstIsInt && secondIsInt)
//{
//    Console.WriteLine($"sum is {firstResult + secondResult}");
//    Console.WriteLine($"{firstResult - secondResult}");
//    Console.WriteLine($"{firstResult * secondResult}");
//    Console.WriteLine($"{firstResult % secondResult}");
//}

//კლავიატურიდან შემოიტანს ორ რიცხვს და გაუცვლის მათ მნიშვნელობას. (მაგ. თუ x-ში შეინახავთ რიცხვს 5-ს y-ში 3-ს
//უნდა დაწეროთ პროგრამა რომლის შედეგადაც x და y ის მნიშვნელობა გაუცვლის ადგილს ერთმანეთს.(swap)

//int num1, num2;
//Console.WriteLine("Enter x number");
//string x = Console.ReadLine();

//bool xIsInt = int.TryParse(x, out int xnum1);

//if (!xIsInt)
//{
//    Console.WriteLine($"{x} is not number");
//    xnum1 = 100;
//}

//Console.WriteLine("Enter y number");
//string y = Console.ReadLine();

//bool yIsInt = int.TryParse(y, out int ynum2);

//Console.WriteLine($"x is equal to {xnum1} ");
//Console.WriteLine($"y is equal to {ynum2} ");

//int damatebiticvladi;
//damatebiticvladi = xnum1;
//xnum1 = ynum2;
//ynum2 = damatebiticvladi;

//Console.WriteLine($"x is equal to {xnum1} after change");
//Console.WriteLine($"y is equal to {ynum2} after change");

//კონსოლიდან(კლავიატურიდან) შემოიტანს 4 რიცხვს და გამოითვლის ამ რიცხვების საშუალოს.

//int shetaniliRaodenoba = 0;

//Console.WriteLine("Enter first number");
//string firstNumber = Console.ReadLine();
//shetaniliRaodenoba++;

//bool firstIsInt = int.TryParse(firstNumber, out int firstResult);

//if (!firstIsInt)
//{
//    Console.WriteLine($"{firstNumber} is not number");
//    firstResult = 100;
//}

//Console.WriteLine("Enter second number");
//string secondNumber = Console.ReadLine();
//shetaniliRaodenoba++;

//bool secondIsInt = int.TryParse(secondNumber, out int secondResult);

//if (!secondIsInt)
//{
//    Console.WriteLine($"{secondNumber} is not number");
//    secondResult = 100;
//}

//Console.WriteLine((firstResult + secondResult) / shetaniliRaodenoba);

//რომელიც კელვინს გადაიყვანს ცელსიუსში(კონცერტაციის ფორმულა ნახეთ ინტერნეტში 🙂 )

//double c;
//double ritskhvi = 273.15;

//Console.WriteLine("Enter k");
//string k = Console.ReadLine();
//bool kIsInt = int.TryParse(k, out int kResult);

//c = kResult - ritskhvi;

//Console.WriteLine(c);

//კლავიატურიდან შემოიტანს რიცხვს და თუ ეს რიცხვი დადებითია დაბეჭდავს ტექსტ “number is positive”

//    Console.WriteLine("Enter number");
//    string number = Console.ReadLine();

//    bool numberIsDouble = double.TryParse(number, out double numberResult);

//    if (!numberIsDouble)
//    {
//        Console.WriteLine($"{number} is not number"); 
//        }

//    if (numberResult >= 0)
//    {
//        Console.WriteLine($"{numberResult} is positive");
//    }
//    else
//    {
//        Console.WriteLine($"{numberResult} is negative, try again");
//    }

//კლავიატურიდან შემოიტანს 3 რიცხვს და დაბეჭდავს ამ 3 რიცხვიდან უმცირესს /უდიდესს

//int a, b, c;
//a = 1; b = 5; c = 8;

//int min, max;

//if (a > b)
//{
//    min = b;
//    max = a;
//}
//else
//{
//    min = a;
//    max = b;
//}

//if (c > max)
//{
//    max = c;
//}

//if (c < min)
//{
//    min = c;
//}

//Console.WriteLine(min);
//Console.WriteLine(max);

//კლავიატურიდან შემოიტანს ორ რიცხვს და თუ ეს ორი რიცხვი ტოლია გაზრდის მათ მნიშვნელობებს 3 ჯერ
//Console.WriteLine("Enter number");
//string number = Console.ReadLine();

//bool numberIsDouble = double.TryParse(number, out double numberResult);

//if (!numberIsDouble)
//{
//       Console.WriteLine($"{number} is not number");
//}

//Console.WriteLine("Enter number");
//string number1 = Console.ReadLine();

//bool number1IsDouble = double.TryParse(number1, out double number1Result);

//if (!number1IsDouble)
//{
//    Console.WriteLine($"{number1} is not number");
//}

//if(numberResult == number1Result)
//{
//    numberResult = numberResult * 3;
//    number1Result = number1Result * 3;
//    Console.WriteLine($"{numberResult} is number");
//    Console.WriteLine($"{number1Result} is number 2");
//}
//else
//{
//    Console.WriteLine("They are not equal");
//}

//კლავიატურიდან შემოტანილ რიცხვს შეამოწმებს არის თუ არა 7 -ის ჯერადი.

//Console.WriteLine("Enter number");
//string number = Console.ReadLine();

//bool numberIsDouble = double.TryParse(number, out double numberResult);

//if (numberResult%7==0)
//{
//    Console.WriteLine($"{number} aris 7is jeradi");
//}
//else
//{
//    Console.WriteLine($"{number} ar aris 7is jeradi");
//}

//კლავიატურიდან შემოიტანს რიცხვს და დაბეჭდავს შეიცავს თუ არა ეს რიცხვი ციფრ 5-ს.

//Console.WriteLine("Enter number");
//string number = Console.ReadLine();

//bool numberIsDouble = double.TryParse(number, out double numberResult);

//double division=0;

//while (division != 5)
//{
//    division = numberResult % 10;

//    if (division == 5)
//    {
//        Console.WriteLine($"{numberResult} includes 5");
//    }
//    else
//    {
//        numberResult = numberResult / 10;
//        numberResult = Math.Truncate(numberResult);
//        if (numberResult == 0)
//        {
//            division = 5;
//        }
//        Console.WriteLine($"{numberResult} doesn't include 5");
//    }
//}
//კლავიატურიდან შემოიტანს ამ რიცხვს და დაბეჭდავს ამ რიცხვის ციფრებს.(მაგ 324 უნდა დაბეჭდოს 3 2 4
//int number = 324;

//int division;

//division = number / 100;
//Console.WriteLine(division);

//number = number % 100;
//division = number / 10;
//Console.WriteLine(division);
//number = number % 10;
//Console.WriteLine(number);