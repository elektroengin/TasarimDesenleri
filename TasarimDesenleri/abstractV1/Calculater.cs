namespace abstractV1
{
    // abstract class : soyut sınıf
    //Soyut sınıflardan doğrudan nesne oluşturulamaz, ancak soyut sınıflardan türetilen sınıflar bu soyut metotları uygulamak zorundadır.
    //Soyut sınıflardaki soyut metotlar, türetilen sınıflar tarafından implemente edilmelidir.
    public abstract class Calculater
    {
        public abstract decimal Hesapla(int a, int b);
    }
}
