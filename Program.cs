internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.WriteLine("Br sayı giriniz");
        int sayı = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girmiş olduğunuz sayı :" +sayı);    // Bu kod doğru  olmakla beraber hatalı sonuca ulaılabilineceği
        */ 
                                                           //  için aşağıdaki şekilde try cath finally ile yazmak gererk
        /*
        try
        {

        Console.WriteLine("Br sayı giriniz");
        int sayı = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Girmiş olduğunuz sayı :" +sayı);

        }
        catch(Exception ex)
        {
            Console.WriteLine("Hata: "+ ex.Message.ToString());
        }
        finally       // Bu try formatında istersen finally kısmı olmasada olablir sana kalmış.
        {
            Console.WriteLine("işlem tamamlandı.");
        }
        */



        try           // Farklı bir hata karşılığı vermek için başka örnek
        {
           // int a = int.Parse(null);
           //int a = int.Parse("test");   // grilen test cevabı int veri tipine uygun değğildir.
           int a = int.Parse("-30000000000");   // girilen değer ya çok küçük veya çok büyük
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer girdiniz.");
            Console.WriteLine(ex);
        }

        catch(FormatException ex)
        {
            Console.WriteLine("Veri tipi uygun değil");
            Console.WriteLine(ex);
        }

        catch(OverflowException ex)
        {
            Console.WriteLine("Çok küçük yada çok büyük br değer girdiniz.");
            Console.WriteLine(ex);
        }
        finally{
            Console.WriteLine("İşlem başarıyla tamamlandı");
        }

    }
}