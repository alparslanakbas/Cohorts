// 10x Kendime inanıyorum --- I believe myself -_-
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

// 1/20 arası rakamlar 
for (int i = 1;i <= 20; i++)
{
    Console.WriteLine(i);
}

// 1/20 arası çift rakamlar
for (int i = 0; i <= 20; i+=2)
{
    Console.WriteLine(i);
}

// 50-150 arasında ki rakamların toplamı
int total = 0;
for (int i = 50; i <= 150; i++)
{
    total += i;
}
Console.WriteLine("50-150 arasında ki sayıların toplamı: " + total);

// 1-120 arasında ki tek ve çift rakamların ayrı toplamı
int PozitiveTotal = 0;
int NegativeTotal = 0;

// negatif için
for (int i = 1; i <= 120; i+= 2)
{
    NegativeTotal += i;
}
Console.WriteLine("1-120 arasında ki tek sayıların toplamı: " + NegativeTotal);

//pozitif için
for (int i = 0; i <= 120; i += 2)
{
    PozitiveTotal += i;
}
Console.WriteLine("1-120 arasında ki çift sayıların toplamı: " + PozitiveTotal);