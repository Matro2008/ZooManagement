using System;

public abstract class Animale
{
    
    public string Nome { get; set; }
    public string Specie { get; set; }
    public int Eta { get; set; }
    public double Peso { get; set; }
    public string StatoDiSalute { get; set; }
    public DateTime DataArrivo { get; set; }

    
    public int AnniAlloZoo => (DateTime.Now - DataArrivo).Days / 365;

    
    private double _pesoIniziale;
    private int _numeroControlliVeterinari;

    
    private double CalcolaVariazionePesoPercentuale() =>
        ((Peso - _pesoIniziale) / _pesoIniziale) * 100;

    private void DeterminaStatoSaluteAutomatico()
    {
        if (Peso < 0 || Eta < 0)
            StatoDiSalute = "Critico";
        else if (_numeroControlliVeterinari < 3)
            StatoDiSalute = "Discreto";
        else
            StatoDiSalute = "Ottimo";
    }

    public Animale(string nome, string specie, int eta, double peso, DateTime dataArrivo)
    {
        Nome = nome;
        Specie = specie;
        Eta = eta;
        Peso = peso;
        DataArrivo = dataArrivo;
        _pesoIniziale = peso;
        _numeroControlliVeterinari = 0;
        StatoDiSalute = "Buono";
    }

   
    public virtual double CalcolaCiboDiarioKg() => Peso / 20;

    public virtual double CalcolaCostoGestioneMensile() => 100;

    public virtual string EmettiVerso() => "L'animale emette un verso";

    public void AggiornaPeso(double nuovoPeso)
    {
        if (nuovoPeso <= 0)
            throw new ArgumentException("Il peso non può essere negativo o zero.");
        Peso = nuovoPeso;
        DeterminaStatoSaluteAutomatico();
    }

    public void EffettuaControlloVeterinario()
    {
        _numeroControlliVeterinari++;
        DeterminaStatoSaluteAutomatico();
    }

    public virtual void MostraInformazioni()
    {
        Console.WriteLine($"[{Specie}] {Nome} - {Eta} anni - {Peso} kg - Salute: {StatoDiSalute}");
        Console.WriteLine($"  Peso iniziale: {_pesoIniziale} kg (Variazione: {CalcolaVariazionePesoPercentuale():0.0}%)");
        Console.WriteLine($"  Controlli veterinari effettuati: {_numeroControlliVeterinari}");
        Console.WriteLine($"  Allo zoo da {AnniAlloZoo} anni");
        Console.WriteLine($"  Cibo giornaliero: {CalcolaCiboDiarioKg():0.0} kg");
        Console.WriteLine($"  Costo mensile: €{CalcolaCostoGestioneMensile():0.0}");
    }
}
