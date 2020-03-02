using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class montaAvatar : MonoBehaviour
{
    //são só quatro opções de cor de pele
    public Image corpo1, corpo2, corpo3, corpo4;
    //a roupa é universal a todos os avatares
    public Image roupa, rosto;
    //tenho quatro cores de cabelo + oito opções de corte para cada, logo tenho trinta e dois cortes
    //loiro
    public Image cabeloL1, cabeloL2, cabeloL3, cabeloL4, cabeloL5, cabeloL6, cabeloL7, cabeloL8;
    //moreno
    public Image cabeloM1, cabeloM2, cabeloM3, cabeloM4, cabeloM5, cabeloM6, cabeloM7, cabeloM8;
    //preto
    public Image cabeloP1, cabeloP2, cabeloP3, cabeloP4, cabeloP5, cabeloP6, cabeloP7, cabeloP8;
    //ruivo
    public Image cabeloR1, cabeloR2, cabeloR3, cabeloR4, cabeloR5, cabeloR6, cabeloR7, cabeloR8;

    public static int opcaoPele;
    public static int cabelo;
    public static int corCabelo;

    //Vou usar a função start para inicializar o avatar
    void Start()
    {   
        corpo1.enabled = false;
        corpo2.enabled = false;
        corpo3.enabled = false;
        corpo4.enabled = false;

        roupa.enabled = false;
        rosto.enabled = false;

        cabeloL1.enabled = false;
        cabeloL2.enabled = false;
        cabeloL3.enabled = false;
        cabeloL4.enabled = false;
        cabeloL5.enabled = false;
        cabeloL6.enabled = false;
        cabeloL7.enabled = false;
        cabeloL8.enabled = false;

        cabeloM1.enabled = false;
        cabeloM2.enabled = false;
        cabeloM3.enabled = false;
        cabeloM4.enabled = false;
        cabeloM5.enabled = false;
        cabeloM6.enabled = false;
        cabeloM7.enabled = false;
        cabeloM8.enabled = false;
    
        cabeloP1.enabled = false;
        cabeloP2.enabled = false;
        cabeloP3.enabled = false;
        cabeloP4.enabled = false;
        cabeloP5.enabled = false;
        cabeloP6.enabled = false;
        cabeloP7.enabled = false;
        cabeloP8.enabled = false;

        cabeloR1.enabled = false;
        cabeloR2.enabled = false;
        cabeloR3.enabled = false;
        cabeloR4.enabled = false;
        cabeloR5.enabled = false;
        cabeloR6.enabled = false;
        cabeloR7.enabled = false;
        cabeloR8.enabled = false;
        iniciaAvatar();
    }

    void iniciaAvatar(){
        roupa.enabled = true;
        rosto.enabled = true;
        //branco
        if(opcaoPele == 1){
            if(corCabelo == 1){ //loiro
                if(cabelo == 1){
                    cabeloL1.enabled = true;
                    corpo1.enabled = true;
                    roupa.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloL2.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloL3.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloL4.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloL5.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloL6.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloL7.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloL8.enabled = true;
                    corpo1.enabled = true;
                }
            }
            else if(corCabelo == 2){ //moreno
                if(cabelo == 1){
                    cabeloM1.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloM2.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloM3.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloM4.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloM5.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloM6.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloM7.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloM8.enabled = true;
                    corpo1.enabled = true;
                }
            }
            else if(corCabelo == 3){ //preto
                if(cabelo == 1){
                    cabeloP1.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloP2.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloP3.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloP4.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloP5.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloP6.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloP7.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloP8.enabled = true;
                    corpo1.enabled = true;
                }                
            }
            else if(corCabelo == 4){ //ruivo
                if(cabelo == 1){
                    cabeloR1.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloR2.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloR3.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloR4.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloR5.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloR6.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloR7.enabled = true;
                    corpo1.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloR8.enabled = true;
                    corpo1.enabled = true;
                }                
            }
        }
        //indigena
        else if(opcaoPele == 2){
            if(corCabelo == 1){ //loiro
                if(cabelo == 1){
                    cabeloL1.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloL2.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloL3.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloL4.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloL5.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloL6.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloL7.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloL8.enabled = true;
                    corpo2.enabled = true;
                }
            }
            else if(corCabelo == 2){ //moreno
                if(cabelo == 1){
                    cabeloM1.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloM2.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloM3.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloM4.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloM5.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloM6.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloM7.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloM8.enabled = true;
                    corpo2.enabled = true;
                }
            }
            else if(corCabelo == 3){ //preto
                if(cabelo == 1){
                    cabeloP1.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloP2.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloP3.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloP4.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloP5.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloP6.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloP7.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloP8.enabled = true;
                    corpo2.enabled = true;
                }                
            }
            else if(corCabelo == 4){ //ruivo
                if(cabelo == 1){
                    cabeloR1.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloR2.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloR3.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloR4.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloR5.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloR6.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloR7.enabled = true;
                    corpo2.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloR8.enabled = true;
                    corpo2.enabled = true;
                }                
            }
        }
        //negro
        else if(opcaoPele == 3){
            if(corCabelo == 1){ //loiro
                if(cabelo == 1){
                    cabeloL1.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloL2.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloL3.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloL4.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloL5.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloL6.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloL7.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloL8.enabled = true;
                    corpo3.enabled = true;
                }
            }
            else if(corCabelo == 2){ //moreno
                if(cabelo == 1){
                    cabeloM1.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloM2.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloM3.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloM4.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloM5.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloM6.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloM7.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloM8.enabled = true;
                    corpo3.enabled = true;
                }
            }
            else if(corCabelo == 3){ //preto
                if(cabelo == 1){
                    cabeloP1.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloP2.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloP3.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloP4.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloP5.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloP6.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloP7.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloP8.enabled = true;
                    corpo3.enabled = true;
                }                
            }
            else if(corCabelo == 4){ //ruivo
                if(cabelo == 1){
                    cabeloR1.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloR2.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloR3.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloR4.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloR5.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloR6.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloR7.enabled = true;
                    corpo3.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloR8.enabled = true;
                    corpo3.enabled = true;
                }                
            }
        } 
        //pardo
        else if(opcaoPele == 4){
               if(corCabelo == 1){ //loiro
                if(cabelo == 1){
                    cabeloL1.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloL2.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloL3.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloL4.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloL5.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloL6.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloL7.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloL8.enabled = true;
                    corpo4.enabled = true;
                }
            }
            else if(corCabelo == 2){ //moreno
                if(cabelo == 1){
                    cabeloM1.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloM2.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloM3.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloM4.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloM5.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloM6.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloM7.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloM8.enabled = true;
                    corpo4.enabled = true;
                }
            }
            else if(corCabelo == 3){ //preto
                if(cabelo == 1){
                    cabeloP1.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloP2.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloP3.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloP4.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloP5.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloP6.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloP7.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloP8.enabled = true;
                    corpo4.enabled = true;
                }                
            }
            else if(corCabelo == 4){ //ruivo
                if(cabelo == 1){
                    cabeloR1.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 2){
                    cabeloR2.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 3){
                    cabeloR3.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 4){
                    cabeloR4.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 5){
                    cabeloR5.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 6){
                    cabeloR6.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 7){
                    cabeloR7.enabled = true;
                    corpo4.enabled = true;
                }
                else if(cabelo == 8){
                    cabeloR8.enabled = true;
                    corpo4.enabled = true;
                }                
            }
        }
    }
    
}
