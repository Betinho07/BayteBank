namespace BayteBank;

public class ContaCorrente
{
    public static int TotalDeContaCriada { get; private set; }
    public ContaCorrente(int agencia, string conta)
    {
        Agencia = agencia;
        Conta = conta;
        TotalDeContaCriada++;
    }
    public int Agencia { get; private set; }
    public string Conta { get; private set; }
    public Cliente Titular { get; set; }
    private double _saldo = 100;

    public double Saldo 
    {
        get
        {
            return _saldo;
        }
        set
        {
            if (value < 0)
            {
                return;
            }

            _saldo = value;

        }
        
    }

    public void Depositar(double valor)
    {
        _saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (_saldo < valor)
        {
            return false;
        }
        
            _saldo -= valor;
            return true;

    }

    public bool Tranferir(double valor, ContaCorrente destino)
    {
        if (_saldo < valor)
        {
            return false;
        }
        else
        {
            
            _saldo -= valor;
            destino.Depositar(valor);
            
            return true;
        }
    }

    public void ExibiContaCorrete()
    {
        Console.WriteLine("************************************************");
        Console.WriteLine($"Seu Nome: {Titular.Nome}");
        Console.WriteLine($"Seu CPF: {Titular.Cpf}");
        Console.WriteLine($"Sua Profição: {Titular.Proficao}");
        Console.WriteLine($"Sua Agencia: {Agencia}");
        Console.WriteLine($"Sua Conta: {Conta}");
        Console.WriteLine($"Seu Saldo: {Saldo}");
        Console.WriteLine("*************************************************");
        
    }
}