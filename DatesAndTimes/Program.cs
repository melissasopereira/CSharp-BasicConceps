namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            //Both Date & Time 
            Console.WriteLine(myValue.ToString());
            
            // Only Date 
            Console.WriteLine(myValue.ToShortDateString());


            // Only Time 
            Console.WriteLine(myValue.ToShortTimeString());

            // Long date displayed as: Wednesday, July 20, 2023
            Console.WriteLine(myValue.ToLongDateString());

            // Long time displayed as: 16:50:34
            Console.WriteLine(myValue.ToLongTimeString());

            // Under this command you can ADD or SUBTRACT (by using the minus "-" sign) days, months, hours, seconds and so on. 
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            Console.WriteLine(myValue.Month);
            Console.WriteLine(myValue.Day);
            Console.WriteLine(myValue.Year);

            Console.WriteLine(DateTime.Now.ToString("dd/MMMM/yyyyy"));

            // To specify a date specifically e.g. Birthday. 
            DateTime myBday = new DateTime(1996, 09, 11); 
            Console.WriteLine(myBday.ToShortDateString());

            // Time Span: It calculates how many days are you alive. 
            DateTime myBirthday = DateTime.Parse("09/11/1996");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();

           
        }
    }
      
}
