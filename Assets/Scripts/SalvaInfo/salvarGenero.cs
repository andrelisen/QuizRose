using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class salvarGenero : MonoBehaviour
{
    public void salvaDados(int botao)
    {
       if(botao == 0){
           print("É mulher!");
           escolhaAvatar.genero = 0;
           dadosBD.genero = 0;
       }
       else if(botao == 1){
           print("É homem!");
           escolhaAvatar.genero = 1;
           dadosBD.genero = 1;
       }
       else if(botao == 2){
           print("Não escolheu!");
           escolhaAvatar.genero = 2;
           dadosBD.genero = 2;
       }
    }
}
