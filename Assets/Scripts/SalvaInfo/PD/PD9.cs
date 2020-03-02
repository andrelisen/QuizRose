using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PD9 : MonoBehaviour
{
     public void resposta(int opcao){
      
        if(opcao == 0){
            print("BTN 0!");
            dadosBD.PD9=0;
        }
        
        else if(opcao == 1){
            print("BTN 1!");
            dadosBD.PD9=1;
        }
        
        else if(opcao == 2){
            print("BTN 2!");
            dadosBD.PD9=2;
        }
        
        else if(opcao == 3){
            print("BTN 3!");
            dadosBD.PD9=3;
        }

        else if(opcao == 4){
            print("BTN 4!");
            dadosBD.PD9=4;
        }
    }
}
