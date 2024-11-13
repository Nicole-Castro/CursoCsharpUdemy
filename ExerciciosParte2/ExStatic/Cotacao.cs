namespace ExStatic;

public class Cotacao
{
    public static double Iof = 6.0;
    public static double Valor(double cotacao, double quantValor){
        double total = quantValor * cotacao;
        return total + total * Iof/100.0;
    }
}
