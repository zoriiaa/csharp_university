﻿namespace Task5
{

 public class Program
{
    public static double GetAverage(int[] marks)
    {
        int sum = 0;
        foreach (int mark in marks)
        {
            sum += mark;
        }
        return sum / marks.Length;
    }

    public static int GetMin(int[] marks)
    {
        int min = marks[0];
        foreach (int mark in marks)
        {
            if (mark < min)
            {
                min = mark;
            }
        }
        return min;
    }

    public static int GetMax(int[] marks)
    {
        int max = marks[0];
        foreach (int mark in marks)
        {
            if (mark > max)
            {
                max = mark;
            }
        }
        return max;
    }

    public static void PrintGroupStatistics(int[][] groups)
    {
        for (int i = 0; i < groups.Length; i++)
        {
            double avg = GetAverage(groups[i]);
            int min = GetMin(groups[i]);
            int max = GetMax(groups[i]);
            Console.WriteLine($"Група {i + 1}: Середній = {avg:F0}, Мінімальний = {min}, Максимальний = {max}");
        }
    }

    public static void Main()
    {

        int[][] groups = new int[][]
        {
            new int[] { 60, 70, 80, 90, 100 },
            new int[] { 50, 65, 75, 85, 95 },
            new int[] { 90, 92, 94, 96, 98, 100 }
        };

        PrintGroupStatistics(groups);
    }
}
}
