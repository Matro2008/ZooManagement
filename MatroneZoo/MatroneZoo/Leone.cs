using System;

public class Leone : Animale
{
   
    public bool IsMaschio { get; set; }
    public double LunghezzaCriniera { get; set; } 

    
    private double _temperaturaCorporeaC;
    private DateTime _ultimaPredazione;

    
    public Leone(string nome, int eta, double peso, DateTime dataArrivo, bool isMaschio, double lunghezzaCriniera)
        : base(nome, "Leone", eta, peso, dataArrivo)
    {
        IsMaschio = isMaschio;
        LunghezzaCriniera = lunghezzaCriniera;
        _temperaturaCorporeaC = 38.5; 
        _ultimaPredazione = DateTime.Now.AddDays(-1); 
    }

    
    private int CalcolaGiorniDallUltimaPredazione() =>
        (DateTime.Now - _ultimaPredazione).Days;

    private void VerificaTemperaturaAnomala()
    {
        if (_temperaturaCorporeaC < 37 || _temperaturaCorporeaC > 40)
            throw new InvalidOperationException("Temperatura corporea anomala.");
    }

    
    public override double CalcolaCiboDiarioKg() => 9; 

    public override double CalcolaCostoGestioneMensile() => 400;

    public override string EmettiVerso() => "ROARRR!";

    
    public void RegistraPredazione()
    {
        _ultimaPredazione = DateTime.Now;
    }

    public override void MostraInformazioni()
    {
        base.MostraInformazioni();
        Console.WriteLine($"  Maschio: {IsMaschio} | Criniera: {LunghezzaCriniera} cm");
        Console.WriteLine($"  Giorni dall'ultima predazione: {CalcolaGiorniDallUltimaPredazione()}");
        Console.WriteLine($"  Temperatura corporea: {_temperaturaCorporeaC}°C");
    }
}
