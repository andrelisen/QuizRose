using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOffset : MonoBehaviour
{
    private Material materialAtual;
	private float velocidade = 1;
	private float offset;
	
	void Start(){
		materialAtual = GetComponent<Renderer>().material;
	}
	
	void FixedUpdate(){
		offset += 0.01f;
		
		materialAtual.SetTextureOffset("_MainTex", new Vector2(0,offset * velocidade));
	}

}
