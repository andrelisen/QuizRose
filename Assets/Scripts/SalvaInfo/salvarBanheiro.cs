using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salvarBanheiro : MonoBehaviour
{
    
    public void salvaDados(int botao)
    {
       if(botao == 0){
           print("Nenhum banheiro!");
           dadosBD.P2=0;
       }
       else if(botao == 1){
           print("1 banheiro!");
           dadosBD.P2=1;
       }
       else if(botao == 2){
           print("2 banheiros!");
           dadosBD.P2=2;
       }
       else if(botao == 3){
           print("3 banheiros!");
           dadosBD.P2=3;
       }
       else if(botao == 4){
           print("4 banheiros!");
           dadosBD.P2=4;
       }
       else if(botao == 5){
           print("5 banheiros!");
           dadosBD.P2=5;
       }
       else if(botao == 6){
           print("Mais de 5 banheiros!");
           dadosBD.P2=6;
       }
       
    }

}
