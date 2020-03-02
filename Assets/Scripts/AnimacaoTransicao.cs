using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoTransicao : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public void IniciaTransicao()
    {
        animator.SetTrigger("Inicia");
    }
}
