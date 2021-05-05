using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> submission = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] arrArg = input.Split("-");
                string username = arrArg[0];

                if (arrArg.Length > 2)
                {
                    string language = arrArg[1];
                    int points = int.Parse(arrArg[2]);
                    if (!students.ContainsKey(username))
                    {
                        students.Add(username, points);
                    }
                    else
                    {
                        if (students[username] < points)
                        {
                            students[username] = points;
                        }
                    }

                    if (!submission.ContainsKey(language))
                    {
                        submission.Add(language, 0);
                    }
                    submission[language]++;
                }
                else
                {
                    if (students.ContainsKey(username))
                    {
                        students.Remove(username);
                    }
                }

            }
            Console.WriteLine("Results:");

            foreach (var kvp in students.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var kvp in submission.OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
