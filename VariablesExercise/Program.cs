namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string petName = "Beni";
            int petAge = 1;
            char petGender = 'M';
            bool isAltered = true;
            double petWeightKg = 2.7;
            decimal adoptionFee = 120.00m;
            
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"I have a pet cat named {petName}. He ({petGender}) is {petAge} year(s) old.");
            Console.WriteLine($"His adoption fee was ${adoptionFee}.");
            Console.WriteLine("His current status is:");
            Console.WriteLine($"   - Neutered:      {isAltered}");
            Console.WriteLine($"   - Weight (kg):   {petWeightKg}");
        }
    }
}
