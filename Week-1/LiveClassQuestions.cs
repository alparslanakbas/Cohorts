namespace Week_1
{
    public class LiveClassQuestions
    {
        // Hello word message
        public void HelloWord()
        {
            Console.WriteLine("Merhaba Dünya");
        }

        // + Calculator
        public void Calculate()
        {
            int number1, number2, total;

            Console.WriteLine("1. sayıyı girin:");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayıyı girin:");
            number2 = int.Parse(Console.ReadLine());

            total = number1 + number2;
            Console.WriteLine($"Toplamı : {total}");
        }

        // Age border
        public void AgeLimit()
        {
            int age = 0;
            Console.WriteLine("Yaşınızı girin: ");
            age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Yetişkinsiniz");
            }

            else
            {
                Console.WriteLine("Çocuksunuz");
            }
        }

        // Your number negative or pozitive
        public void NegativeOrPozitive()
        {
            int number = 0;
            Console.WriteLine("Bir sayı değer giriniz: ");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"Girilen Sayı : {number} çifttir.");
            }

            else
            {
                Console.WriteLine($"Girilen Sayı : {number} tektir.");
            }
        }

        // Weather calculate 
        public void Weather()
        {
            int celsius = 0;
            Start:
            Console.WriteLine("Sıcaklık değerini girin: ");
            if (!int.TryParse(Console.ReadLine(), out celsius)) // burada yapılan işlem eğer girilen değer integera çevrilemiyorsa,
                                                                // size hata mesajı döner ve kodun başlangıcı nereye belirlendiyse oraya yönlendirir.
            {
                Console.WriteLine("Lütfen sıcaklık birimini rakam üzerinden girin!");
                goto Start;
            } 

            else if (celsius < 0)
            {
                Console.WriteLine("Donuyor");
            }

            else if(celsius >= 0 && celsius <=30)
            {
                Console.WriteLine("Normal");
            }

            else if (celsius > 30)
            {
                Console.WriteLine("Sıcak");
            }

            else
            {
                Console.WriteLine("Bilinmeyen bir hata lütfen değerlerinizi kontrol edin");
                goto Start;
            }
        }

        // Week of days
        public void Weeks()
        {
            int value = 0;
            Start:
            Console.WriteLine("1-7 arasında gün sayısı girin: ");
            value = int.Parse(Console.ReadLine());

            switch (value)
            {
                case 1: 
                    Console.WriteLine("Pazartesi"); 
                    break;

                case 2:
                    Console.WriteLine("Salı");
                    break;

                case 3:
                    Console.WriteLine("Çarşamba");
                    break;

                case 4:
                    Console.WriteLine("Perşembe");
                    break;

                case 5:
                    Console.WriteLine("Cuma");
                    break;

                case 6:
                    Console.WriteLine("Cumartesi");
                    break;

                case 7:
                    Console.WriteLine("Pazar");
                    break;

                default:
                    Console.WriteLine("Geçersiz gün!");
                    goto Start;
            }
        }

        // Exam Calculator
        public void ExamCalculate()
        {
            Start:
            Console.WriteLine("Sınav puanınızı girin: ");
            int note = int.Parse(Console.ReadLine()); // her zaman yukarıda sabit bir değer tanımlamak yerine bu şekilde de kullanabilirsiz, en best practice olanı budur, az kod..

            if (note < 0)
            {
                Console.WriteLine("Sınav puanı 0' dan düşük olamaz!");
                goto Start;
            }

            else if (note == 0 || note <= 60)
            {
                Console.WriteLine("Başarısız");
            }

            else if (note >= 61 && note <= 80)
            {
                Console.WriteLine("Orta");
            }

            else if (note >= 81)
            {
                Console.WriteLine("Başarılı");
            }

            else
            {
                Console.WriteLine("Bilinmeyen bir hata lütfen değerlerinizi kontrol edin");
                goto Start;
            }
        }

        // 1-12 Month of days
        public void Months()
        {
            Start:
            Console.WriteLine("Lütfen istediğiniz ay'ı rakam olarak girin");
            int month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak 31 gün");
                    break;

                case 2:
                    Console.WriteLine("Şubat 28 gün");
                    break;

                case 3:
                    Console.WriteLine("Mart 31 gün");
                    break;

                case 4:
                    Console.WriteLine("Nisan 30 gün");
                    break;

                case 5:
                    Console.WriteLine("Mayıs 31 gün");
                    break;

                case 6:
                    Console.WriteLine("Haziran 30 gün");
                    break;

                case 7:
                    Console.WriteLine("Temmuz 31 gün");
                    break;

                case 8:
                    Console.WriteLine("Ağustos 31 gün");
                    break;

                case 9:
                    Console.WriteLine("Eylül 30 gün");
                    break;

                case 10:
                    Console.WriteLine("Ekim 31 gün");
                    break;

                case 11:
                    Console.WriteLine("Kasım 30 gün");
                    break;

                case 12:
                    Console.WriteLine("Aralık 31 gün");
                    break;

                default:
                    Console.WriteLine("Yanlış değer girdiniz.");
                    goto Start;
            }

        }

        // Login password check
        public void Login()
        {
            int password = 12345;

            Console.WriteLine("Lütfen şifrenizi girin: ");
            password = int.Parse(Console.ReadLine());

            if (password == 12345)
            {
                Console.WriteLine("Giriş başarılı");
            }

            else
            {
                Console.WriteLine("Giriş başarısız");
            }       

        }

        // Calculator
        public void Calculator()
        {
            double result;
            int mod1, mod2, modresult;
            char menu = '0';

            Console.WriteLine("***************");
            Console.WriteLine("Basit Hesap Makinesi");
            Console.WriteLine("***************");
        Menu:
            Console.WriteLine("Toplama için 1");
            Console.WriteLine("Çıkarma için 2");
            Console.WriteLine("Çarpma için 3");
            Console.WriteLine("Bölme için 4");
            Console.WriteLine("Mod Alma İçin 5");
            Console.WriteLine("Çıkış için 0");
            menu = Convert.ToChar(Console.ReadLine());
            if (menu == '1')
            {
                Console.Clear();
            num1:
                Console.WriteLine("İlk Sayıyı Giriniz:");
                string num1 = Console.ReadLine();
                double matchNum1;
                bool result1 = double.TryParse(num1, out matchNum1);
                if (true != result1)
                {
                    goto num1;
                }

            num2:
                Console.WriteLine("İkinci Sayıyı Giriniz:");
                string num2 = Console.ReadLine();
                double matchNum2;
                bool result2 = double.TryParse(num2, out matchNum2);
                if (true != result2)
                {
                    goto num2;
                }
                result = Convert.ToDouble(num1) + Convert.ToDouble(num2);
                Console.WriteLine("Sonuç:" + result);
                goto Menu;

            }
            else if (menu == '2')
            {
                Console.Clear();
            num1:
                Console.WriteLine("İlk Sayıyı Giriniz:");
                string num1 = Console.ReadLine();
                double matchNum1;
                bool result1 = double.TryParse(num1, out matchNum1);
                if (true != result1)
                {
                    goto num1;
                }

            num2:
                Console.WriteLine("İkinci Sayıyı Giriniz:");
                string num2 = Console.ReadLine();
                double matchNum2;
                bool result2 = double.TryParse(num2, out matchNum2);
                if (true != result2)
                {
                    goto num2;
                }
                result = Convert.ToDouble(num1) - Convert.ToDouble(num2);
                Console.WriteLine("Sonuç:" + result);
                goto Menu;

            }
            else if (menu == '3')
            {
                Console.Clear();
            num1:
                Console.WriteLine("İlk Sayıyı Giriniz:");
                string num1 = Console.ReadLine();
                double matchNum1;
                bool result1 = double.TryParse(num1, out matchNum1);
                if (true != result1)
                {
                    goto num1;
                }

            num2:
                Console.WriteLine("İkinci Sayıyı Giriniz:");
                string num2 = Console.ReadLine();
                double matchNum2;
                bool result2 = double.TryParse(num2, out matchNum2);
                if (true != result2)
                {
                    goto num2;
                }
                result = Convert.ToDouble(num1) * Convert.ToDouble(num2);
                Console.WriteLine("Sonuç:" + result);
                goto Menu;

            }
            else if (menu == '4')
            {
                Console.Clear();
            num1:
                Console.WriteLine("İlk Sayıyı Giriniz:");
                string num1 = Console.ReadLine();
                double matchNum1;
                bool result1 = double.TryParse(num1, out matchNum1);
                if (true != result1)
                {
                    goto num1;
                }
            num2:
                Console.WriteLine("İkinci Sayıyı Giriniz:");
                string num2 = Console.ReadLine();
                double matchNum2;
                bool result2 = double.TryParse(num2, out matchNum2);
                if (true != result2 && matchNum2 <= 0)
                {
                    goto num2;
                }
                result = Convert.ToDouble(num1) / Convert.ToDouble(num2);
                Console.WriteLine("Sonuç:" + result);
                goto Menu;

            }
            else if (menu == '5')
            {
                Console.Clear();
            num1:
                Console.WriteLine("İlk Sayıyı Giriniz:");
                string num1 = Console.ReadLine();
                double matchNum1;
                bool result1 = double.TryParse(num1, out matchNum1);
                if (true != result1)
                {
                    goto num1;
                }
            num2:
                Console.WriteLine("İkinci Sayıyı Giriniz:");
                string num2 = Console.ReadLine();
                double matchNum2;
                bool result2 = double.TryParse(num2, out matchNum2);
                if (true != result2 && matchNum2 <= 0)
                {
                    goto num2;
                }
                result = Convert.ToDouble(num1) % Convert.ToDouble(num2);
                Console.WriteLine("Sonuç:" + result);
                goto Menu;
            }
            else if (menu == '0')
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Lütfen Geçerli Bir Rakam Giriniz.!");
                goto Menu;
            }

            Console.ReadKey();
        }
    }
}
