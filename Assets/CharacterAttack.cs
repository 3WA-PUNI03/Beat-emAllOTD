using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterAttack : MonoBehaviour
{

    [SerializeField] InputActionReference _attackInput;
    [SerializeField] HitZone _hitZone;

    private void Update()
    {
        // ON check si le bouton d'attack vient d'etre enfoncé
        if (_attackInput.action.WasPressedThisFrame())
        {
            // C'est le cas, donc on parcours la liste des colliders detectés
            // Et sur chaque collider on choppe le composant Health et on appelle
            // TakeDamage dessus.
            foreach (Collider2D col in _hitZone.Colliders)
            {
                Debug.Log($"attack {col.attachedRigidbody.name}");
                // Le composant Health est au même endroit que le RB de notre ennemi
                Health h = col.attachedRigidbody.GetComponent<Health>();
                // On peut appeller TakeDamage dessus
                h.TakeDamage();
            }
        }

    }



}
