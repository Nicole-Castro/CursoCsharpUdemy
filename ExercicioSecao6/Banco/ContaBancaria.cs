using System.Globalization;

namespace Banco;

public class ContaBancaria
{
    public int NumConta { get; private set; }
    private string _nome;
    public double Saldo {get; private set;}
    public ContaBancaria(int numConta, string nome)
    {
        NumConta = numConta;
        _nome = nome;
    }
    public ContaBancaria(int numConta, string nome, double depositoInicial) :this(numConta, nome)
    {
        Deposito(depositoInicial);
    }

    public string getNome()
    {
        return _nome;
    }
    public string Nome
    {
        get { return _nome; }
        set
        {
            if (value != null && value.Length > 1)
            {
                _nome = value;
            }
        }
    }

    public void Deposito(double valor)
    {
        Saldo = Saldo + valor;
    }

    public void Saque(double valor)
    {
        Saldo = Saldo - valor - 5.0;
    }

    override public string ToString()
    {
        return "Conta " + NumConta + ", Titular: " + _nome + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }

}
