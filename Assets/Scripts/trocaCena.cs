using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class trocaCena : MonoBehaviour 
{
    public void carregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }
}