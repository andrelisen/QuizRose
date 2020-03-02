using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PI : MonoBehaviour
{
    public InputField respostaOutra;
    private string tutorialText;

  
     public void resposta(int opcao){
         if(opcao == 1 || opcao == 2 || opcao == 3 || opcao == 4 || opcao == 5 || opcao == 6 ){
             if(opcao == 1){
                 dadosBD.PI1N=1;
                 dadosBD.PI1S="0";
                // int.TryParse("1", out dadosBD.PI1S);

             }
             else if(opcao == 2){
                 dadosBD.PI1N=2;
                dadosBD.PI1S="0";
                // int.TryParse("2", out dadosBD.PI1S);

             }
             else if(opcao == 3){
                 dadosBD.PI1N=3;
                dadosBD.PI1S="0";
                // int.TryParse("3", out dadosBD.PI1S);

             }
             else if(opcao == 4){
                 dadosBD.PI1N=4;
                 dadosBD.PI1S="0";
                 //int.TryParse("4", out dadosBD.PI1S);

             }
             else if(opcao == 5){
                 dadosBD.PI1N=5;
                 dadosBD.PI1S="0";
                 //int.TryParse("5", out dadosBD.PI1S);
             }
             else if(opcao == 6){
                 dadosBD.PI1N=6;
                 dadosBD.PI1S="0";
                // int.TryParse("6", out dadosBD.PI1S);
             }
         }
        }


        public void Start()
     {
        tutorialText = PlayerPrefs.GetString("");
        respostaOutra.text = tutorialText; 
     }

        public void SaveThis(){
        tutorialText = respostaOutra.text;
        PlayerPrefs.SetString("tutorialTextName", tutorialText);
        //Valor da idade ficou aqui!
        print(tutorialText);
        dadosBD.PI1S = tutorialText;
        dadosBD.PI1N=0;
        //int.TryParse(tutorialText, out dadosBD.PI1S); //transforma string em int no caso tutorialText para dadosBD idade
     }
}
