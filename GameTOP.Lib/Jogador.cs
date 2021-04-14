namespace GameTOP.Lib
{
    public class Jogador : iJogador{
        
        public readonly string _Nome;
        public string Nome {get; set;}
        public Jogador(string nome = "Ronaldo")
        {
            _Nome = nome;
        }
        public string chuta (){
            return $"Ronaldo está chutando \n";
        }

        public string corre (){
            return $"Ronaldo está correndo \n";
        }
        public string passe (){
            return $"Ronaldo está passando \n";
        }
    }
}