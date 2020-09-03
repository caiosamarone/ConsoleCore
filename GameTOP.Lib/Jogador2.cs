using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
           return "Maradona está chutando la bola \n";
        }

        public string Corre()
        {
           return "\nMaradona está correndo \n";
        }

        public string Passe()
        {
           return "Maradona está passando la bola \n";
        }
    }
}