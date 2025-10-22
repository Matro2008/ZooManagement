using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamettaZoo
{
    class Animale
    {
        public string Nme { get set; }

        public string Specie { get; set; }

        public int Eta { get; set; }

        public double Peso { get; set; }

        public string StatoSalute { get; set; }

        public int DataArrivo { get; set }

        public int DataAttuale { get; set; }

        public int AnniAlloZoo { get; set; }

        private float _pesoIniziale;

        private int _ControlliVeterinari;

        private int _VariazionePeso;

        private int _StatoSaluteAt;

        public virtual void CalcolaCiboDiarioKg()
        {

        }
        public virtual void CalcolaCostoGestioneMensile()
        {

        }
        public virtual void EmettiVerso()
        {

        }
        public double AggionaPeso(double nuovoPeso);
        
        public virtual void MostraInfo()
        {

        }
    }
}
