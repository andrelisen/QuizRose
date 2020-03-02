using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverLado : MonoBehaviour
{
    private Material materialAtual;
	private float velocidade = 0.1f;
	private float offset;
	
	void Start(){
		materialAtual = GetComponent<Renderer>().material;
	}
	
	void FixedUpdate(){
		offset += 0.01f;
		
		materialAtual.SetTextureOffset("_MainTex", new Vector2(offset * velocidade, 0));
	}

}
