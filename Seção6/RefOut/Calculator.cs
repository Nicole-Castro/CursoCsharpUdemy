namespace RefOut;

public class Calculator
{
    public static void Triple(ref int x){
        x = x*3;
    }

    public static void TripleOut(int x, out int y){
        y = x*3;
    }
}
