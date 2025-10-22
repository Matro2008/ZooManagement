using MatroneZoo;
using System;

namespace MatroneZoo
{
    class Leone : Animale
    {
        
        public float LunghezzaCriniera { get; set; }

        private double _temperaturaCorporeaC;

        private int _ultimaPredazione;

        
        private double CalcolaGiorniDallUltimaPredazione()
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
            base.EmettiVerso();
        }

        
        public int OreDiSonnoAlGiorno()
        {
            return 0;
        }

        public int RegistraPredazione()
        {
            return 0;
        }
    }
}
