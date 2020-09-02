using System;

namespace E09.OnTimefortheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());
            int examTime = examHour * 60 + examMinutes;
            int arriveTime = arriveHour * 60 + arriveMinutes;
            if (arriveTime > examTime)
            {
                Console.WriteLine("Late");
                int lateMinutes = arriveTime - examTime;
                if (lateMinutes < 60)
                {
                    Console.WriteLine($"{lateMinutes} minutes after the start");
                }
                else
                {
                    int hourLate = lateMinutes / 60;
                    int minutesLate = lateMinutes % 60;
                    if (minutesLate < 10)
                    {
                        Console.WriteLine($"{hourLate}:0{minutesLate} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hourLate}:{minutesLate} hours after the start");
                    }
                }
            }
            else if (arriveTime == examTime || examTime - arriveTime <= 30)
            {
                Console.WriteLine("On time");
                int onTime = examTime - arriveTime;
                if (onTime <= 30 && onTime != 0)
                {
                    Console.WriteLine($"{onTime} minutes before the start");
                }
            }
            else if (examTime - arriveTime > 30)
            {
                int diff = examTime - arriveTime;
                Console.WriteLine("Early");
                if (examTime - arriveTime < 60)
                {
                    Console.WriteLine($"{diff} minutes before the start");
                }
                else
                {
                    int hour = diff / 60;
                    int minutes = diff % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hour}:0{minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hour}:{minutes} hours before the start");
                    }
                }
            }
        }
    }
}
