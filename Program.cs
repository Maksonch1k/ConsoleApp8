namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
             static int CalculateAge(DateTime dateOfBirth)
            {
                DateTime today = DateTime.Now;
                int age = today.Year - dateOfBirth.Year;

                if (today.Month < dateOfBirth.Month)
                {
                    age--;
                }
                else if (today.Month == dateOfBirth.Month && today.Day < dateOfBirth.Day)
                {
                    age--;
                }

                return age;
                Console.ReadKey();
            }
        }
    }
}