using BarcodeLib;
using barcode_generator_reader;

namespace barcode_generator_reader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Barkod oluşturma işlemine hoş geldiniz...");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
            int islem=0;
             do
                {
                    printOptions();
                    try
                    {
                        islem = Convert.ToInt32(Console.ReadLine());
                    }
                    catch{}
                    if(islem == 1)
                    {
                        Console.WriteLine("Lütfen barkod sıra numarası giriniz:");
                        string deger = Console.ReadLine();
                        if(deger.Length > 2) 
                    {
                        Barcode barcode =Process.CreateAndSaveBarcode(deger);
                        StreamWriter Yaz = new StreamWriter(@"C:\Users\gokha\Desktop\Pratikler\Barcode-Generator-Reader\kayit.txt",true);  
                        Yaz.WriteLine("Barkod Değeri: " + barcode.RawData);  
                        Yaz.Close();
                    }else{Console.WriteLine("Yanlış ve ya eksik tuşlama yaptınız...");}
                
                }
                else if(islem == 2)
                {
                    Console.WriteLine("Lütfen barkod sıra numarası giriniz:");
                    string deger = Console.ReadLine();
                    Barcode barcode = new Barcode(deger);
                    Process.ReadBarcode(barcode);
                    if(barcode.RawData == deger)
                    {
                        Console.WriteLine(Process.ReadBarcode(barcode));
                    }

                }
                }
                while(islem != 3);
                Console.WriteLine("Teşekkürler, iyi günler dileriz.");
            
           
        }

        private static void printOptions()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz...");
            Console.WriteLine("1 - Barkod Oluşturma");
            Console.WriteLine("2 - Barkod Okuma");
            Console.WriteLine("3 - Çıkış");
        }

        
  
    }
}





