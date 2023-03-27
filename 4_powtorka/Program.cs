// See https://aka.ms/new-console-template for more information

//Pierwszy program - rozgrzewka
//Console.WriteLine("Podaj swoje imię:");
//var name = Console.ReadLine();
//Console.WriteLine("Hello " + name);
//
//int result = 5 + 9;
//
/////Zadanie 1
//int number=1;
//float money=3.46F;
//string tekst="text";
//bool isLogged=true;
//char myChar='a';
//decimal price=4.55M;
//
/////Zadanie 2
//string myAge = "Age:";
//int wifeAge = 18;
//var result = myAge + wifeAge;
//Console.WriteLine(result);
//
//Console.ReadKey();
//
/////Zadanie 3
//bool isTrue = true;
//bool isFalse = false;
//bool isReallyTrue = true;
//
//bool and = isTrue & isFalse;
//bool or = isTrue || isFalse;
//bool negative = !isFalse;
//
//Console.WriteLine(and+" "+ or+" "+ negative);
//Console.ReadKey();
//
////Zadanie 4
//var a = 5;
//var b = 12;
//var add = a + b;
//var sub = a - b;
//var div = a / b;
//var mul = a * b;
//var mod = a % b;
//
//Console.WriteLine(add+" "+sub + " "+div + " "+mul + " "+mod);
//
////Zadanie 5
//string a5, b5, c5;
//a5 = "Ala ";
//b5 = "ma ";
//c5 = "kota.";
//
//var result5 = a5 + b5 + c5;
//
//Console.WriteLine(result5);
//Console.ReadKey();
//
/////Instrukcje sterujące i pętle
/////Zadanie 1
/////
//int n1 = 10;
//int n2 = 20;
//if (n1 > n2)
//{
//    Console.WriteLine("n1 jest większe od n2");
//}
//else if(n1 == n2){
//    Console.WriteLine("n1 jest równe n2");
//}
//else
//{
//
//    Console.WriteLine("n2 jest większe od n1");
//}
//
////Zadanie 2
//for(int i = 0; i < 10; i++)
//{
//    Console.WriteLine("C#");
//}
//int j = 0;
//while (j < 10)
//{
//    Console.WriteLine("C#");
//    j++;
//}
//
////Zadanie 3
//int n = 10;
//
//for(int i=0; i<n;i++){
//	if(i%2==0){
//	Console.WriteLine("Parzysta");
//	}
//		else{
//	Console.WriteLine("Nieparzysta");
//		}	

////Zadanie 4
///
//int n = 5;
//for(int i=0; i < n; i++)
//{
//    for(int j = 0; j <= i; j++)
//    {
//        Console.Write("* ");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();

////Zadanie 5

// int exam=57;

// switch (exam)
// {
    // case < 0:
    // case > 100:
		// Console.WriteLine("Wartość poza zakresem");
		// break;
	// case <40:
		// Console.WriteLine("Ocena Niedostateczna");
		// break;
	// case <55:
		// Console.WriteLine("Ocena Dopuszczająca");
		// break;
	// case <70:
		// Console.WriteLine("Ocena Dostateczna");
		// break;
	// case <85:
		// Console.WriteLine("Ocena Dobra");
		// break;
	// case <99:
		// Console.WriteLine("Ocena Bardzo Dobra");
		// break;
	// case <101:
		// Console.WriteLine("Ocena Celująca");
		// break;

// }

///Kolekcje
//Zadanie 1

// string [] colors={"white","black","red","blue"};

// Console.WriteLine(string[0]);
// Console.WriteLine(string[3]);

//Zadanie 2

// int [] numbers={1,2,3,4,5,6,7,8,9,10};
		
// for(int i=0;i<numbers.Length ;i++){
	// Console.WriteLine($"Liczba: {numbers[i]}");
// }

// foreach(int n in numbers){
	// Console.WriteLine($"Liczba: {n}");
// }
// int i_while=0;
// while(i_while<numbers.Length){
	// Console.WriteLine($"Liczba: {numbers[i_while]}");
	// i_while++;
// }

//Zadanie 3
List<string> fruits = new List<string>();
		
fruits.Add("Jabłko");
fruits.Add("Banan");
fruits.Add("Kiwi");
fruits.Add("Grejpfrut");

for(int i=0;i<3;i++){
	Console.Write(fruits[i]+", ");
}
Console.Write(fruits[fruits.Count-1]);
