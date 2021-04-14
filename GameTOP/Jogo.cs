using System;

namespace GameTOP{
    public class Jogo{ 
        private readonly iJogador _jogador;
        private readonly iJogador _jogador2;

        public Jogo(iJogador jogador, iJogador jogador2){
            _jogador = jogador;
            _jogador2 = jogador2;
        }
       public void iniciarJogo()
        {
            Console.Write(_jogador.chuta());
            Console.Write(_jogador.corre());
            Console.Write(_jogador.passe());
            Console.Write("\n Proximo Jogador \n");
            Console.Write(_jogador2.chuta());
            Console.Write(_jogador2.corre());
            Console.Write(_jogador2.passe());

        }
    }
    
}
