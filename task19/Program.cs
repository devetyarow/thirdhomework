// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// вспомнить че такое палиндром

Console.Write("Enter five-digit number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Your number: {number} - palindrome.");
  }
  else Console.WriteLine($"Your number: {number} - Not palindrome.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Enter five-digit number");