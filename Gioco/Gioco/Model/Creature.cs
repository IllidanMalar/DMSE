using System.Collections.Generic;

namespace Gioco.Model
{
    public enum EDado
    {
        D2, D4, D6, D8, D10, D12, D20, D100
    }

    public static class SituazioneIniziale
    {
        public static Coordinate PartenzaGiocatore = new Coordinate(1, 1);
        public static Coordinate PartenzaMostro = new Coordinate(6, 6);
        public const int DimensioneMappa = 8;
    }

    public class Coordinate
    {
        public int X,
            Y;

        public Coordinate( int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Creature
    {
        public string Nome;
        public int PuntiFerita;
        public int ClasseArmatura;
        public int TiroPerColpire;
        public EDado TipoDado;
        public int NumeroDadi;
        public List<string> OggettiList;
        public string NomeGiocatore;
        public Coordinate Posizione;

        public Creature( string nome, int puntiFerita, int classeArmatura, int tiroPerColpire, EDado dado, int numeroDadi, List<string> oggetti, string nomeGiocatore = null )
        {
            this.Nome = nome;
            PuntiFerita = puntiFerita;
            ClasseArmatura = classeArmatura;
            TiroPerColpire = tiroPerColpire;
            TipoDado = dado;
            NumeroDadi = numeroDadi;
            OggettiList = oggetti;
            NomeGiocatore = nomeGiocatore;
        }

        public bool AssegnaPosizione(int x, int y)
        {
            Posizione = new Coordinate(x, y);
            return true;
        }

        public static Creature CreaScheletro()
        {
            return new Creature("Scheletro", 10, 5, 5, EDado.D8, 1, new List<string>{"Oggetto Quest", "Spada", "10_Monete"});
        }

        public static Creature Eroe()
        {
            return new Creature("Giampiero", 15, 5, 6, EDado.D10, 1, new List<string> { "Spadone", "Scudo", "5_Monete" }, "Giocatore");
        }
    }

    public class Cartoncino
    {
        public int DimensioneX,
            DimensioneY;

        public Casella[ , ] Area;
        
        public class Casella
        {
            private bool _walkable;

            public Casella(bool camminabile)
            {
                _walkable = camminabile;
            }

            public bool IsCamminabile()
            {
                return _walkable;
            }
        }

        public Cartoncino(int x, int y)
        {
            Area = new Casella[x , y];

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    if( i == 0 || j == 0 || i == (x - 1) || j == (y - 1)) 
                        Area[i, j] = new Casella(false);
                    else 
                        Area[i, j] = new Casella(true);
                }
            }
        }
    }
}
