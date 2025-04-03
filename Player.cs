using System;

class Player{
    private char symbol = 'X';
    public void markAPlace(Board board){
        char input_row = '1';
        char input_col = '1';
        while(!isInRange(input_row)){
            Console.Write("Ingrese la fila: ");
            input_row = Console.ReadKey().KeyChar;
        }
        int row = ctoi(input_row);
        while(!isInRange(input_col)){
            Console.Write("Ingrese la fila: ");
            input_col = Console.ReadKey().KeyChar;
        }
        int col = ctoi(input_col);
        board.placeSymbol(row-1, col-1, symbol);
    }
    public int ctoi(char c){
        return c - '0';
    }
    public bool isInRange(char c){
        if(c>=49 && c<=51) return true;
        else{
            Console.Write("    Posición invalida.");
            return false;
        }
    }
}