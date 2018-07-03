using System;
using System.Collections.Generic;
using System.IO;

class Solution {

static void nextMove(int posr, int posc, String [] board){
    //cleanbot begins in the top right corner and 
    //works down, cleaning each row as it moves
    if(board[posr][posc] == 'd')
    {
        Console.WriteLine("CLEAN");
        return;
    }
    
    if(board[posr].Contains("d"))
    {
        if(board[posr].IndexOf('d') < posc)
            Console.WriteLine("LEFT");
        else
            Console.WriteLine("RIGHT");
        return;
    }
    
    //search for new dirt
    for(int i = 0; i < board.Length; i++)
    {
        if(board[i].IndexOf("d") > -1){
            
            if(i < posr)
                Console.WriteLine("UP");
            else
                Console.WriteLine("DOWN");
            return;
        }
        
    }

    Console.WriteLine("I AM LOST");
    
    }

static void Main(String[] args) {
        String temp = Console.ReadLine();
        String[] position = temp.Split(' ');
        int[] pos = new int[2];
        String[] board = new String[5];
        for(int i=0;i<5;i++) {
            board[i] = Console.ReadLine();
        }
        for(int i=0;i<2;i++) pos[i] = Convert.ToInt32(position[i]);
        nextMove(pos[0], pos[1], board);
    }
}
