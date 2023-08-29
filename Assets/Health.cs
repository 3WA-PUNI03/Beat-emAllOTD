using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int _startHealth;

    public void TakeDamage()
    {

        _startHealth -= 10;

        if(_startHealth <= 0)
        {
            Destroy(gameObject);


            //StartCoroutine(  DeathCoroutine()  );
        }

    }

    // Si on veut lancer une animation avant de faire le destroy
    IEnumerator DeathCoroutine()
    {
        // Animator


        // Wait
        yield return new WaitForSeconds(2);

        // Destroy
        Destroy(gameObject);
    }

}
