using System;

public class Elefante : Animale
{
    
    public double LunghezzaProboscide { get; set; }
    public double ConsumoDiAcquaLitri { get; set; }

    
    private int _salutePelle;
    private int _frequenzaBagniSettimanali;

    
    public Elefante(string nome, int eta, double peso, DateTime dataArrivo, double lunghezzaProboscide)
        : base(nome, "Elefante", eta, peso, dataArrivo)
    {
        LunghezzaProboscide = lunghezzaProboscide;
        ConsumoDiAcquaLitri = 200; 
        _salutePelle = 95; 
        _frequenzaBagniSettimanali = 2; 
    }

   
    private void CalcolaSalutePelle()
    {
        
        _salutePelle = (int)Math.Min(100, _salutePelle + _frequenzaBagniSettimanali * 2);
    }

    private void VerificaIdratazione()
    {
        if (ConsumoDiAcquaLitri < 150)
            throw new InvalidOperationException("L'elefante non sta bevendo abbastanza acqua.");
    }

    
    public override double CalcolaCiboDiarioKg() => 180; 

    public override double CalcolaCostoGestioneMensile() => 800; 

    public override string EmettiVerso() => "Barrrrrito!";

    
    public void RegistraBagno()
    {

        _frequenzaBagniSettimanali++;
        CalcolaSalutePelle();



    }
}



