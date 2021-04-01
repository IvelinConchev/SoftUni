using System;

namespace _08._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberNight = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                if (numberNight > 7 && numberNight <= 14)
                {
                    double apartmentPrice = numberNight * 65;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);

                    double studioPrice = numberNight * 50;
                    double disount = studioPrice * 0.05;
                    double sumStudio = studioPrice - disount;
                    Console.WriteLine("Studio: {0:f2} lv.", sumStudio);
                }
                else if (numberNight > 14)
                {
                    double apartmentPrice = numberNight * 65;
                    double discount = apartmentPrice * 0.1;
                    double sumApartment = apartmentPrice - discount;
                    Console.WriteLine("Apartment: {0:f2} lv.", sumApartment);

                    double studioPrice = numberNight * 50;
                    double disount = studioPrice * 0.3;
                    double sumStudio = studioPrice - disount;
                    Console.WriteLine("Studio: {0:f2} lv.", sumStudio);
                }
                else
                {
                    double apartmentPrice = numberNight * 65;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);

                    double studioPrice = numberNight * 50;
                    Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
                }
            }
            else if (month == "June" || month == "September")
            {
                if (numberNight > 14)
                {
                    double apartmentPrice = numberNight * 68.70;
                    double discount = apartmentPrice * 0.1;
                    double sumApartment = apartmentPrice - discount;
                    Console.WriteLine("Apartment: {0:f2} lv.", sumApartment);

                    double studioPrice = numberNight * 75.20;
                    double disount = studioPrice * 0.2;
                    double sumStudio = studioPrice - disount;
                    Console.WriteLine("Studio: {0:f2} lv.", sumStudio);
                }
                else
                {
                    double apartmentPrice = numberNight * 68.70;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);

                    double studioPrice = numberNight * 75.20;
                    Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
                }
            }
            else
            {
                if (numberNight > 14)
                {
                    double apartmentPrice = numberNight * 77;
                    double discount = apartmentPrice * 0.1;
                    double sumApartment = apartmentPrice - discount;
                    Console.WriteLine("Apartment: {0:f2} lv.", sumApartment);

                    double studioPrice = numberNight * 76;
                    Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
                }
                else
                {
                    double apartmentPrice = numberNight * 77;
                    Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);

                    double studioPrice = numberNight * 76;
                    Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
                }
            }
        }
    }
}
