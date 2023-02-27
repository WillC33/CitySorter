using System;

public class CitySorter
{
    static void Main(string[] args)
    {
        string tmesta = "Praha, Brno, Plzeň, Ostrava, Liberec, Olomouc, Jihlava, Kolín, Tábor, Čáslav, Bratislava, Košice, Žilina, Poprad, Trenčín";
        string tstaty = "Česko, Slovensko";

        string[] mesta = tmesta.Split(", ");
        string[] staty = tstaty.Split(", ");

        int longestCityIndex = GetLongestCityIndex(mesta);

        Console.WriteLine("Longest city name: " + mesta[longestCityIndex]);

        string state = (longestCityIndex < 10) ? staty[0] : staty[1];
        Console.WriteLine("State: " + state);
    }

    static int GetLongestCityIndex(string[] cities)
    {
        int maxIndex = 0;
        for (int i = 1; i < cities.Length; i++)
        {
            if (cities[i].Length > cities[maxIndex].Length)
            {
                maxIndex = i;
            }
        }
        return maxIndex;
    }
}