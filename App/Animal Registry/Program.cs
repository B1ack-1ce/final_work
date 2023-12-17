
namespace Animal_Registry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
                Controller.Controller.Start();
            } 
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
