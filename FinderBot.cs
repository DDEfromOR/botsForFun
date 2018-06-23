
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
        
        if(princessX < 0 || princessY < 0 || robotX < 0 || robotY < 0)
        {
            return;
        }
        
        int moves = 0;

        while (robotX != princessX || robotY != princessY)
        {
            if (robotX < princessX)
            {
                System.Console.WriteLine("RIGHT");
                robotX++;
            }

            if (robotX > princessX)
            {
                System.Console.WriteLine("LEFT");
                robotX--;
            }

            if (robotY < princessY)
            {
                System.Console.WriteLine("DOWN");
                robotY++;
            }

            if (robotY > princessY)
            {
                System.Console.WriteLine("UP");
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
