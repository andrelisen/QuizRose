using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class salvarEscola : MonoBehaviour
{
    public InputField respostaEscola;
    private string tutorialText;

    void Start()
    {
        tutorialText = PlayerPrefs.GetString("");
        respostaEscola.text = tutorialText; 
    }

    public void SaveThis(){
        tutorialText = respostaEscola.text;
        PlayerPrefs.SetString("tutorialTextName", tutorialText);
        //Valor da idade ficou aqui!
        print(tutorialText);
        dadosBD.escola=tutorialText;
    }
}
