using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PF12 : MonoBehaviour
{
     public void resposta(int opcao){
      
        if(opcao == 0){
            print("BTN 0!");
            dadosBD.PF12=0;
        }
        
        else if(opcao == 1){
            print("BTN 1!");
            dadosBD.PF12=1;
        }
        
        else if(opcao == 2){
            print("BTN 2!");
            dadosBD.PF12=2;
        }
        
        else if(opcao == 3){
            print("BTN 3!");
            dadosBD.PF12=3;
        }

        else if(opcao == 4){
            print("BTN 4!");
            dadosBD.PF12=4;
        }
    }
}
