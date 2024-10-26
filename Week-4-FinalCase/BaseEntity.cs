using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_FinalCase
{
    public abstract class BaseEntity
    {
        public BaseEntity(string name, string? description, string? operationSystem)
        {
            Name = name;
            Description = description;
            OperationSystem = operationSystem;
        }

        public string Name { get; set; } = string.Empty!;
        public string? Description { get; set; }
        public Guid SerialNumber { get; set; } = Guid.NewGuid();
        public string? OperationSystem { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public void WriteToConsoleCommonInfo()
        {
            Console.WriteLine
                (
                    $"Model Seri Numarası: {SerialNumber}\n" +
                    $"Model Adı:  {Name}\n" +
                    $"Model Açıklaması:  {Description}\n" +
                    $"Model İşletim Sistemi:  {OperationSystem}\n" +
                    $"Model Üretim Tarihi:  {CreatedDate}"
                );
        }

    }

    public class Computer : BaseEntity
    {
        private int _usbPortCount;
        private bool _isBluetooth;
        public Computer(string name, string? description, string? operationSystem, bool isBluetooth, int usbPortCount) : base(name, description, operationSystem)
        {
            _isBluetooth = isBluetooth;
            UsbPortCount = usbPortCount;
        }

        public int UsbPortCount
        {
            get => _usbPortCount;
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbPortCount = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz, USB giriş sayısı 2 veya 4 olmalıdır, çıkış yapılıyor..");
                    _usbPortCount = -1;
                    Environment.Exit(0);
                }
            }
        }
        public void WriteToConsoleComputerInfo()
        {
            WriteToConsoleCommonInfo();
            Console.WriteLine($"USB giriş sayısı: {UsbPortCount}");
            Console.WriteLine($"Model Bluetooth özelliği: {(_isBluetooth ? "Var" : "Yok")}");
        }

    }

    public class Phone : BaseEntity
    {
        private bool _isLicenceTR;
        public Phone(string name, string? description, string? operationSystem, bool isLicenceTR) : base(name, description, operationSystem)
        {
            _isLicenceTR = isLicenceTR;
        }

        public void WriteToConsolePhoneInfo()
        {
            WriteToConsoleCommonInfo();
            Console.WriteLine($"Model TR dil desteği: {(_isLicenceTR ? "Var" : "Yok")}");
        }
    }

}
