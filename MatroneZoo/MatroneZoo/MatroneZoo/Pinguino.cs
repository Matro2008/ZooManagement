using System;

namespace MatroneZoo
{
    class Pinguino : Animale
    {
        public float Altezza { get; set; }

        private double _temperaturaCorporeaC;

        private int _ultimaPredazione;

        private double CalcolaGiorniDallUltimaInterazione()
        {
            return 0;
        }

        private double VerificaTemperaturaAnomala()
        {
            return 0;
        }

        public override void CalcolaCostoGestioneMensile()
        {
            base.CalcolaCostoGestioneMensile();
        }

        public override void EmettiVerso()
        {
            Console.WriteLine("Il pinguino emette un suono 'squawk'!");
        }

        public int OreDiSonnoAlGiorno()
        {
            return 16;
        }

        public int RegistraInterazione()
        {
            return 0;
        }
    }
}
