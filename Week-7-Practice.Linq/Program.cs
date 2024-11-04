// Odd numbers and even numbers
IReadOnlyList<int> numbersListOne = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var evenNumbers = numbersListOne.Where(n => n % 2 == 0);
var oddNumbers = numbersListOne.Where(n => n % 2 != 0);
Console.WriteLine("--Tek Sayılar--");
foreach (var number in oddNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine();
Console.WriteLine("--Çift Sayılar--");

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine();

// Pozitive numbers and negative numbers
IReadOnlyList<int> numbersListTwo = new List<int> { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var pozitiveNumbers = numbersListTwo.Where(n => n >= 0);
var negativeNumbers = numbersListTwo.Where(n => n < 0);
Console.WriteLine("--Pozitif Sayılar--");
foreach (var number in pozitiveNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine();
Console.WriteLine("--Negatif Sayılar--");
foreach (var number in negativeNumbers)
{
    Console.WriteLine(number);
}


// numbers greater than 15 and less than 22
IReadOnlyList<int> numbersListThree = new List<int> { 10, 15, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
var numbersGreaterThanFifteen = numbersListThree.Where(n => n >= 15 && n <= 22);
Console.WriteLine("--15 den büyük 22 den küçük rakamlar--");
foreach (var number in numbersGreaterThanFifteen)
{
    Console.WriteLine(number);
}


// The square of each number
Console.WriteLine("--Her bir sayının karesi--");
var squareNumbers = numbersListThree.Select(n => n * n); // math pow kullanmıyorum basit bir çarmpa işlemi olduğu için gerek yok
foreach (var number in squareNumbers)
{
    Console.WriteLine(number);
}