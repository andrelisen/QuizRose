using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PE37 : MonoBehaviour
{
     public void resposta(int opcao){
      
        if(opcao == 0){
            print("BTN 0!");
            dadosBD.PE37=0;
        }
        
        else if(opcao == 1){
            print("BTN 1!");
            dadosBD.PE37=1;
        }
        
        else if(opcao == 2){
            print("BTN 2!");
            dadosBD.PE37=2;
        }
        
        else if(opcao == 3){
            print("BTN 3!");
            dadosBD.PE37=3;
        }

        else if(opcao == 4){
            print("BTN 4!");
            dadosBD.PE37=4;
        }
    }
}
