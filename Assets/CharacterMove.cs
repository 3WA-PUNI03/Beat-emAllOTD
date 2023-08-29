using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMove : MonoBehaviour
{
    [SerializeField] InputActionReference _moveInput;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _speed;

    [SerializeField] Animator _animator;

    void Update()
    {

        Vector2 dir = _moveInput.action.ReadValue<Vector2>();

        _rb.velocity = dir * _speed;

        // Update character's orientation
        if(dir.x > 0) // Right
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if(dir.x < 0)  // Left
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        // Update animator
        if( dir.magnitude > 0 )
        {
            _animator.SetBool("IsWalking", true);
        }
        else
        {
            _animator.SetBool("IsWalking", false);
        }


    }
}
