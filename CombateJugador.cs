using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CombateJugador : MonoBehaviour
{
    [SerializeField] private float vida;

    private Movimiento movimiento;

    [SerializeField] private float tiempoPerdidaControl;

    private Animator animator;

    public event EventHandler MuerteJugador;

    public GameObject Reset;

    private void Start()
    {
        Reset.gameObject.SetActive(false);
        movimiento = GetComponent<Movimiento>();
        animator = GetComponent<Animator>();
    }

    public void TomarDaño(float daño)
    {
        vida -= daño;
        if (vida > 0)
        {
            animator.SetTrigger("Daño");
        }
        else
        {
            animator.SetTrigger("Muerte1");
            Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Jugador"), LayerMask.NameToLayer("Enemigos"), true);
        }
    }

    public void MuerteJugadorEvento()
    {
        MuerteJugador?.Invoke(this, EventArgs.Empty);
    }

    public void TomarDaño(float daño, Vector2 position)
    {
            vida -= daño;
            animator.SetTrigger("Daño");
            StartCoroutine(PerderControl());
            movimiento.Rebote(position);
        if (vida <= 0)
        {
            Destroy(gameObject);
            Reset.gameObject.SetActive(true);
        }
    }

   


    private IEnumerator PerderControl()
    {
        movimiento.sePuedeMover = false;
        yield return new WaitForSeconds(tiempoPerdidaControl);
        movimiento.sePuedeMover = true;
    }

}
