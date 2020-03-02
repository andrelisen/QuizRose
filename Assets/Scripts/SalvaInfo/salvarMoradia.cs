using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class salvarMoradia : MonoBehaviour
{
    public InputField respostaPais;
    private string tutorialText;

    void Start()
    {
        tutorialText = PlayerPrefs.GetString("");
        respostaPais.text = tutorialText; 
    }

    public void SaveThis(){
        tutorialText = respostaPais.text;
        PlayerPrefs.SetString("tutorialTextName", tutorialText);
        //Valor da cidade ficou aqui!
        print(tutorialText);
        dadosBD.cidade=tutorialText;
    }
}
