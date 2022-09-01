// Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число из 5 цифр: ");
string? number = Console.ReadLine();

void Palindrome(string number){
  if (number[0]==number[4] || number[1]==number[3]) {
    Console.WriteLine($"Число {number} - палиндром.");
  }
  else Console.WriteLine($"Число {number} -  не палиндром.");
}

if (number!.Length == 5){
  Palindrome(number);
}
else Console.WriteLine($"Не 5 цифр, нужно 5");