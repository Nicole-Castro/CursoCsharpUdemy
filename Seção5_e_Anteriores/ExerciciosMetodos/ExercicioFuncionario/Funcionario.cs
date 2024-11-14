using System.Globalization;

namespace ExercicioFuncionario;

public class Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido(){
        return SalarioBruto - Imposto;
    }

    public void AumentarSalario(double porcentagem){
        SalarioBruto = (SalarioBruto * (porcentagem/100))+SalarioBruto;
    }

    override public string ToString() {
        return Nome + ", R$" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture); 
    }
}
