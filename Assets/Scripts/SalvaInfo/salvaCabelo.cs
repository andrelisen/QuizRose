using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class salvaCabelo : MonoBehaviour
{
    public void escolheCorCabelo(int opcao){
        //loiro
        if(opcao == 1){
            print("Loiro!");
            montaAvatar.corCabelo = 1;
            dadosBD.cabelo=1;
        }
        //moreno
        else if(opcao == 2){
            print("Moreno!");
            montaAvatar.corCabelo = 2;
            dadosBD.cabelo=2;
        }
        //preto
        else if(opcao == 3){
            print("Preto!");
            montaAvatar.corCabelo = 3;
            dadosBD.cabelo=3;
        }
        //ruivo
        else if(opcao == 4){
            print("Ruivo!");
            montaAvatar.corCabelo = 4;
            dadosBD.cabelo=4;
        }

    }
}
