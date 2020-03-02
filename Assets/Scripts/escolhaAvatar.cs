using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class escolhaAvatar : MonoBehaviour
{
    public static int genero;
    
    void Start(){
        if(genero == 0){
            print("Avatar mulher!");
            SceneManager.LoadScene("avatarPele");
        }
        else if(genero == 1){
            print("Avatar homem!");
            SceneManager.LoadScene("avatarPele");
        }
        else if(genero == 2){
            print("Não quis se identificar!");
            //Carregar cena da primeira pergunta PA
            SceneManager.LoadScene("titulo");
        }
    }

}
