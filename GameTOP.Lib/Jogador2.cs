namespace GameTOP.Lib
{
    public class Jogador2 : iJogador{
        public readonly string _Nome;
        public string Nome {get; set;}
        public Jogador2(string nome = "Maradona")
        {
            
        }
        public string chuta()
        {
            return $"Maradona estas pateando\n";
        }

        public string corre()
        {
            return $"Maradona estas corriendo\n";
        }

        public string passe()
        {
            return $"Maradona estas passeando\n";
        }
    }
}