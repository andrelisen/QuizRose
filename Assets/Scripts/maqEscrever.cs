using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class maqEscrever : MonoBehaviour
{

    public Text textWriter;
    public float delayWriter = 0.05f;
    private string escrevaFrase = " Olá, você está participando de um questionário"+
  " que tem como objetivo descobrir o que é que os alunos de várias partes do mundo pensam da ciência, tanto"+
 " na escola como no seu dia a dia."+ "  "+"Para isso você deve responder com atenção e sinceridade aos questionamentos."+
 "                                                            "+
  "Muito obrigada pela disposição e, divirta-se!";

    void Start() {
        StartCoroutine("mostrarTexto", escrevaFrase);
    }
    
    IEnumerator mostrarTexto(string textType){

        textWriter.text = "";
        for(int letter = 0; letter < textType.Length; letter++){
            textWriter.text = textWriter.text + textType[letter];
            yield return new WaitForSeconds(delayWriter);
        }
    }
}
