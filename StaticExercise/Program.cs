namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in celsius:");
            double whatTemperatureYouGotC = double.Parse(Console.ReadLine());
            TempConverter.CTF(whatTemperatureYouGotC);
            Console.WriteLine();
            Console.WriteLine("Enter temperature in fahrenheit:");
            double whatTemperatureYouGotF = double.Parse(Console.ReadLine());
            TempConverter.FTC(whatTemperatureYouGotF);

        }
    }
}
