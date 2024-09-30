//** For works **//

// 10x Kendime inanıyorum --- I believe myself -_-
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

//// 1/20 arası rakamlar 
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}

//// 1/20 arası çift rakamlar
for (int i = 0; i <= 20; i += 2)
{
    Console.WriteLine(i);
}

//// 50-150 arasında ki rakamların toplamı
int total = 0;
for (int i = 50; i <= 150; i++)
{
    total += i;
}
Console.WriteLine("50-150 arasında ki sayıların toplamı: " + total);

//// 1-120 arasında ki tek ve çift rakamların ayrı toplamı
int PozitiveTotal = 0;
int NegativeTotal = 0;

//// negatif için
for (int i = 1; i <= 120; i += 2)
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


//** While works **//

// 10x Kendime inanıyorum --- I believe myself -_-
int count = 0;
while (count < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    count++;
}

// 1/20 arası rakamlar
int count2 = 1;
while (count <= 20)
{
    Console.WriteLine(count2);
    count2++;
}

// 1/20 arası çift rakamlar
int count3 = 2; // İstenilen görev de 0 değil 1/20 arası sayı istendiği için 2 veriyorz. 1 verirsek tekli sayıları elde ederiz çünkü 2 2 artması gerektiğini söylüyorum.*
while (count3 <= 20)
{
    Console.WriteLine(count3);
    count3 += 2;
}

// 50-150 arasında ki rakamların toplamı
int count4 = 50;
int total2 = 0;
while (count <= 150)
{
    total2 += count4;
    count4++;
}

Console.WriteLine($"50-150 arasında ki sayıların toplamı: {total}"); // Buraya değişkeni iki farklı türde getirebiliriz. $ simgesi string ifadeler de değişkeni çağırmak için kullanıyoruz.
                                                                     // yada kullanmak istemiyorsanız + ile string ifadeden çıkıp direk değişkeni buraya getirebilirsiniz.


//// 1-120 arasında ki tek ve çift rakamların ayrı toplamı
int PozitiveTotal2 = 0;
int NegativeTotal2 = 0;
int total3 = 1;

while (total3 <= 120)
{
    if (total3 % 2 == 0)
    {
        PozitiveTotal2 += total3;
    }

    else
    {
        NegativeTotal2 += total3;
    }
    total3++;
}
Console.WriteLine("1-120 arasında ki tek sayıların toplamı: " + NegativeTotal2);
Console.WriteLine("1-120 arasında ki çift sayıların toplamı: " + PozitiveTotal2);



