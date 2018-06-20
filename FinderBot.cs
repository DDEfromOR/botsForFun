using System;
using System.Collections.Generic;
using System.IO;
class Solution
{

    static void displayPathtoPrincess(int n, String[] grid)
    {
        int princessX = -1;
        int princessY = -1;
        int robotX = -1;
        int robotY = -1;
        
        for(int i = 0; i < n; i++)
        {
            if (grid[i].Contains("p"))
            {
                princessX = i;
                princessY = grid[i].IndexOf('p');
            }

            if (grid[i].Contains("m"))
            {
                robotX = i;
                robotY = grid[i].IndexOf('m');
            }
        }

        while (robotX != princessX || robotY != princessY)
        {
            if (robotX < princessX)
            {
                System.Console.WriteLine("DOWN");
                robotX++;
            }

            if (robotX > princessX)
            {
                System.Console.WriteLine("UP");
                robotX--;
            }

            if (robotY < princessY)
            {
                System.Console.WriteLine("RIGHT");
                robotY++;
            }

            if (robotY < princessY)
            {
                System.Console.WriteLine("LEFT");
                robotY--;
            }
        }
    }

    static void Main(String[] args)
    {
        int m;

        m = int.Parse(Console.ReadLine());

        String[] grid = new String[m];
        for (int i = 0; i < m; i++)
        {
            grid[i] = Console.ReadLine();
        }

        displayPathtoPrincess(m, grid);
    }
}
