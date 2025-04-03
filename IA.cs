using System;

class IA{
    private char symbol = 'O';
    public void randomMark(Board board){
        int row, col;
        row = Random;
        col = Random;
        board.placeSymbol(row, col, symbol);
    }
}