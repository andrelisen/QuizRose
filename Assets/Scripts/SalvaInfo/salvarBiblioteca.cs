using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salvarBiblioteca : MonoBehaviour
{
    public void salvaDados(int botao)
    {
       if(botao == 0){
           print("Nenhum livro!");
           dadosBD.P1=0;
       }
       else if(botao == 1){
           print("1 a 10 livros!");
           dadosBD.P2=1;
       }
       else if(botao == 2){
           print("11 a 50 livros!");
            dadosBD.P1=2;
       }
       else if(botao == 3){
           print("51 a 100 livros!");
           dadosBD.P1=3;
       }
       else if(botao == 4){
           print("101 a 250 livros!");
           dadosBD.P1=4;
       }
       else if(botao == 5){
           print("251 livros a 500!");
           dadosBD.P1=5;
       }
       else if(botao == 6){
           print("Mais de 500 livros!");
           dadosBD.P1=6;
       }
       
    }
}
