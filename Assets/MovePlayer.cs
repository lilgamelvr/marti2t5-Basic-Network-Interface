using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MovePlayer : NetworkBehaviour
{
    [SerializeField]
    private float speed;

    void FixedUpdate()
    {
        if (this.isLocalPlayer)
        {
            float movement = Input.GetAxis("Horizontal");
            float movement2 = Input.GetAxis("Vertical");
            GetComponent<Rigidbody2D>().velocity = new Vector2(movement * speed, movement2 * speed);
        }
    }
}