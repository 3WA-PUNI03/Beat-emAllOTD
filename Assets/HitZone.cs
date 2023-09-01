using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitZone : MonoBehaviour
{
    [SerializeField] List<Collider2D> _colliders;
    [SerializeField] string _tagTotrack;


    public List<Collider2D> Colliders { get => _colliders; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si l'objet detecté n'a pas de rigidbody => on ignore il nous intéresse pas
        if (collision.attachedRigidbody == null) return;

        // En revanche s'il a un rigidbody, dont le tag est _tagTotrack, là on va l'ajouter à notre liste
        if (collision.attachedRigidbody.gameObject.CompareTag(_tagTotrack))
        {
            _colliders.Add(collision);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.attachedRigidbody == null) return;
        if (collision.attachedRigidbody.gameObject.CompareTag(_tagTotrack))
        {
            _colliders.Remove(collision);
        }
    }

}
