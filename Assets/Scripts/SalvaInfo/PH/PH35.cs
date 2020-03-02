using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PH35 : MonoBehaviour
{
     public void resposta(int opcao){
      
        if(opcao == 0){
            print("BTN 0!");
            dadosBD.PH35=0;
        }
        
        else if(opcao == 1){
            print("BTN 1!");
            dadosBD.PH35=1;
        }
        
        else if(opcao == 2){
            print("BTN 2!");
            dadosBD.PH35=2;
        }
        
        else if(opcao == 3){
            print("BTN 3!");
            dadosBD.PH35=3;
        }

        else if(opcao == 4){
            print("BTN 4!");
            dadosBD.PH35=4;
        }
    }
}
