﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PH22 : MonoBehaviour
{
     public void resposta(int opcao){
      
        if(opcao == 0){
            print("BTN 0!");
            dadosBD.PH22=0;
        }
        
        else if(opcao == 1){
            print("BTN 1!");
            dadosBD.PH22=1;
        }
        
        else if(opcao == 2){
            print("BTN 2!");
            dadosBD.PH22=2;
        }
        
        else if(opcao == 3){
            print("BTN 3!");
            dadosBD.PH22=3;
        }

        else if(opcao == 4){
            print("BTN 4!");
            dadosBD.PH22=4;
        }
    }
}
