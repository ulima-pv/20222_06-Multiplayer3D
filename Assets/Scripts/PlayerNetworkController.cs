using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerNetworkController : NetworkBehaviour
{
    public float speed = 3f;
    private void Update()
    {
        if (!IsOwner) return;

        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

        transform.position += new Vector3(
            movementHorizontal * Time.deltaTime * speed,
            0f,
            movementVertical * Time.deltaTime * speed
        );
    }

}
