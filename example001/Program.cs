//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

System.Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;

Polindrom(number);

bool Polindrom(string number){
    if(number.Length == 5){
        if(number[0] == number[4] && number[1] == number[3]){
            Console.WriteLine("Данное число является палиндромом!");
        }
        else{
            Console.WriteLine("Данное число не является палиндромом!");
        }
    }
    else{
        Console.WriteLine("Введено неверное число!");
        return false;
    }
    return true;
}
