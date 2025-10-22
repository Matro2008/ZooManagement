using System;

public class Pinguino : Animale
{
    
    public double TemperaturaAcquaIdeale { get; set; }
    public int NumeroUova { get; set; }

    
    private double _spessoreGrassoSottocutaneoMm;
    private double _tempoInAcquaOreGiornaliere;

    
    public Pinguino(string nome, int eta, double peso, DateTime dataArrivo, double temperaturaAcquaIdeale, int numeroUova)
        : base(nome, "Pinguino", eta, peso, dataArrivo)
    {
        TemperaturaAcquaIdeale = temperaturaAcquaIdeale;
        NumeroUova = numeroUova;
        _spessoreGrassoSottocutaneoMm = 25; 
        _tempoInAcquaOreGiornaliere = 5; 
    }

    
    private double CalcolaIsolamentoTermico() => _spessoreGrassoSottocutaneoMm / 10;

    private void VerificaEsposizioneAcqua()
    {
        if (_tempoInAcquaOreGiornaliere < 4)
            throw new InvalidOperationException("Non ha passato abbastanza tempo in acqua.");
    }

    
    public override double CalcolaCiboDiarioKg() => 1.5; 

    public override double CalcolaCostoGestioneMensile() => 250;

    public override string EmettiVerso() => "Squawk squawk!";

    
    public void RegistraTempoInAcqua(double ore)
    {
        _tempoInAcquaOreGiornaliere = ore;
        VerificaEsposizioneAcqua();
    }

    public override void MostraInformazioni()
    {
        base.MostraInformazioni();
        Console.WriteLine($"  Temperatura acqua ideale: {TemperaturaAcquaIdeale}°C | Uova quest'anno: {NumeroUova}");
        Console.WriteLine($"  Spessore grasso sottocutaneo: {_spessoreGrassoSottocutaneoMm} mm");
        Console.WriteLine($"  Tempo in acqua oggi: {_tempoInAcquaOreGiornaliere} ore");
    }
}
