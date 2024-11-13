﻿namespace ExercicioAluno;

public class Aluno
{
    public string Nome;
    public double Nota1;
    public double Nota2;
    public double Nota3;

    public double NotaFinal(){
        return Nota1 + Nota2 + Nota3;
    }

    public bool Aprovado(){
        if(NotaFinal() >= 60.0){
            return true;
        }else{
            return false;
        }
    }

    public double Reprovado(){
        if(Aprovado()){
            return 0.0;
        }else{
            return 60 - NotaFinal();
        }
    }
}
