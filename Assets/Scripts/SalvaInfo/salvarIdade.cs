using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class salvarIdade : MonoBehaviour
{
    public InputField respostaIdade;
    private string tutorialText;

    void Start()
    {
        tutorialText = PlayerPrefs.GetString("");
        respostaIdade.text = tutorialText; 
    }

    public void SaveThis(){
        tutorialText = respostaIdade.text;
        PlayerPrefs.SetString("tutorialTextName", tutorialText);
        //Valor da idade ficou aqui!
        print(tutorialText);
        int.TryParse(tutorialText, out dadosBD.idade); //transforma string em int no caso tutorialText para dadosBD idade
    }

}
