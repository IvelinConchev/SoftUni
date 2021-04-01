using System;

namespace _09._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            int timeExam = (hourExam * 60) + minutesExam;
            int timeArrival = (hourArrival * 60) + minutesArrival;

            if (timeArrival > timeExam)
            {
                int timeLate = timeArrival - timeExam;

                if (timeLate > 60)
                {
                    decimal hoursLate = timeLate / 60;
                    decimal minsLate = timeLate % 60;
                    Console.WriteLine("{0}:{1:00} hours the start", Math.Floor(hoursLate),minsLate);
                }
                else if (timeLate < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0:00} minutes after the start" , timeLate);
                }
            }
            else if (timeArrival < timeExam)
            {
                decimal timeEarly = timeExam - timeArrival;

                if ((timeEarly > 30) && (timeEarly < 60))
                {
                    decimal hoursEarly = timeEarly / 60;
                    decimal minsEarly = timeEarly % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine("{0:00} minutes before the start", minsEarly);
                }
                else if (timeEarly > 30 && timeEarly >= 60)
                {
                    decimal hoursEarly = timeEarly / 60;
                    decimal minsEarly = timeEarly % 60;
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{0:00} hours before the start", Math.Floor(hoursEarly),minsEarly);
                }
                else if (timeEarly <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", timeEarly);
                }
            }
            else if (timeArrival == timeExam)
            {
                Console.WriteLine("On time");
            }
        }
    }
}
