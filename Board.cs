using System;
using System.Numerics;

class Board{
    private char[,] matrix;
    public Board(){
        matrix = new char[3, 3];
    }
    public void inicialBoard(){
        for(int i = 0; i < 3; ++i){
            for(int j = 0; j < 3; ++j){
                matrix[i, j] = ' ';
            }
        }
    }
    public void showBoard(){
        Console.WriteLine($"    [1] [2] [3]");
        for(int i = 0; i < 3; ++i){
            Console.Write($"[{i+1}]  ");
            for(int j = 0; j < 3; ++j){
                Console.Write(matrix[i, j]);
                if(j < 2) Console.Write(" | ");
            }
            Console.WriteLine();
            if(i < 2) Console.WriteLine("    __________");
        }
    }
    public void placeSymbol(int row, int col, char symbol){
        if(matrix[row, col] == ' '){
            matrix[row, col] = symbol;
        }
    }
    public bool isALineFull(){
        for(int i = 0; i < 3; ++i){
            if(matrix[i, 0] != ' ' && matrix[i, 0] == matrix[i, 1] && matrix[i, 1] == matrix[i, 2]) return true;
            if(matrix[0, i] != ' ' && matrix[0, i] == matrix[1, i] && matrix[1, i] == matrix[2, i]) return true;
        }
        if (matrix[0, 0] != ' ' && matrix[0, 0] == matrix[1, 1] && matrix[1, 1] == matrix[2, 2]) return true;
        if (matrix[0, 2] != ' ' && matrix[0, 2] == matrix[1, 1] && matrix[1, 1] == matrix[2, 0]) return true;
        return false;
    }
}