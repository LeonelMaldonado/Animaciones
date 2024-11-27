using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirYCerrar : MonoBehaviour
{
    public Animator animatorPuerta;
 
    public void AbrirPuerta()
    {
        animatorPuerta.SetBool("Abrir", true);
    }

    public void CerrarPuerta()
    {
        animatorPuerta.SetBool("Abrir", false);
    }
}
