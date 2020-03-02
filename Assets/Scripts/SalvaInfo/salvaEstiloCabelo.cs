using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class salvaEstiloCabelo : MonoBehaviour
{
    public void escolheEstiloCabelo(int opcao){

        if(opcao == 1){
            print("Estilo 1!");
            montaAvatar.cabelo = 1;
        }

        else if(opcao == 2){
            print("Estilo 2!");
            montaAvatar.cabelo = 2;
        }

        else if(opcao == 3){
            print("Estilo 3!");
            montaAvatar.cabelo = 3;
        }
        
        else if(opcao == 4){
            print("Estilo 4");
            montaAvatar.cabelo = 4;
        }

        if(opcao == 5){
            print("Estilo 5");
            montaAvatar.cabelo = 5;
        }

        else if(opcao == 6){
            print("Estilo 6");
            montaAvatar.cabelo = 6;
        }

        else if(opcao == 7){
            print("Estilo 7");
            montaAvatar.cabelo = 7;
        }

        else if(opcao == 8){
            print("Estilo 8");
            montaAvatar.cabelo = 8;
        }

    }
}
