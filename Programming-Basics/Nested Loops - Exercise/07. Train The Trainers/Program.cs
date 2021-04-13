﻿using System;

namespace _07._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            double allScore = 0;
            double counter = 0;

            while (true)
            {
                string nameOfPresentation = Console.ReadLine();
                double sumOfGrades = 0;

                if (nameOfPresentation == "Finish")
                {
                    double scoreSum = allScore / counter;
                    Console.WriteLine($"Student's final assessment is {scoreSum:f2}.");
                    break;
                }
                for (int i = 0; i < numberOfPeople; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades = sumOfGrades + grade;
                    allScore = allScore + grade;
                    counter++;
                }
                double sumAfter = sumOfGrades / numberOfPeople;
                Console.WriteLine($"{nameOfPresentation} - {sumAfter:f2}.");
            }
        }
    }
}