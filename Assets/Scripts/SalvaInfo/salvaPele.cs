using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class salvaPele : MonoBehaviour
{
    
    public void escolhePele(int opcao){
        //branco
        if(opcao == 1){
            print("Branco!");
            montaAvatar.opcaoPele = 1;
            dadosBD.pele=1;
        }
        //indígena
        else if(opcao == 2){
            print("Indígena!");
            montaAvatar.opcaoPele = 2;
            dadosBD.pele=2;
        }
        //negro
        else if(opcao == 3){
            print("Negro!");
            montaAvatar.opcaoPele = 3;
            dadosBD.pele=3;
        }
        //pardo
        else if(opcao == 4){
            print("Pardo!");
            montaAvatar.opcaoPele = 4;
            dadosBD.pele=4;
        }

    }

}
