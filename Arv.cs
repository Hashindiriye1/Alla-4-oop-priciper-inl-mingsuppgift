using System;
internal class Store
{
    // Attributer av klass store
    public string ShoeStore;

    //Metoder av klass store
    public void Open()
    {
        Console.WriteLine("Affären är nu öppen");
    }

    public void Close()
    {
        Console.WriteLine("Affären är nu stängd");
    }



}
class Program
{
    static void Main(string[] args)
    {
        Store myStore = new Store();
        myStore.ShoeStore = "KicksNShit";
        // Här använder jag metoden från Store klassen
        myStore.Open();
        myStore.Close();
    }
}
