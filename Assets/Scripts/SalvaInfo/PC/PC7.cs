using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC7 : MonoBehaviour
{
     public void resposta(int opcao){
      
        if(opcao == 0){
            print("BTN 0!");
            dadosBD.PC7=0;
        }
        
        else if(opcao == 1){
            print("BTN 1!");
            dadosBD.PC7=1;
        }
        
        else if(opcao == 2){
            print("BTN 2!");
            dadosBD.PC7=2;
        }
        
        else if(opcao == 3){
            print("BTN 3!");
            dadosBD.PC7=3;
        }

        else if(opcao == 4){
            print("BTN 4!");
            dadosBD.PC7=4;
        }
    }
}
