using System;

namespace GameTOP.Lib{

    public class Program{
        static void Main(string[] args){
            var jogo = new Jogo(new Jogador(), new Jogador2());
            jogo.iniciarJogo();
        }
    }
}