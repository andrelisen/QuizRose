﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PA48: MonoBehaviour
{
     public void resposta(int opcao){
      
        if(opcao == 0){
            print("BTN 0!");
            dadosBD.PA48=0;
        }
        
        else if(opcao == 1){
            print("BTN 1!");
            dadosBD.PA48=1;
        }
        
        else if(opcao == 2){
            print("BTN 2!");
            dadosBD.PA48=2;
        }
        
        else if(opcao == 3){
            print("BTN 3!");
            dadosBD.PA48=3;
        }

        else if(opcao == 4){
            print("BTN 4!");
            dadosBD.PA48=4;
        }
    }
}
