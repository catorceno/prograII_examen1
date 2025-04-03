using System;

class Game{
    private Board board;
    private Player player;
    private IA ia;
    public Game(){
        board = new();
        player = new();
        ia = new();
    }
    public void play(){
        int contador = 1;
        char turn = 'X';
        board.inicialBoard();
        Console.WriteLine($"Bienvenido a Tres en Raya! Tu símbolo es la 'X'");
        while(contador <= 9){
            board.showBoard();
            if(turn == 'X') player.markAPlace(board);
            else ia.randomMark(board);
            if(board.isALineFull()) {Console.WriteLine($"El jugador {turn} ha ganado!"); break;}
            ++contador;
        }
        Console.WriteLine("Hubo un empate!");
    }
}