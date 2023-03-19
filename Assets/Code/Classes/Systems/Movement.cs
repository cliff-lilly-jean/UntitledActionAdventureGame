using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update()
    {
        getMovementDirection();
    }

    void getMovementDirection()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 walkDirection = new Vector3(horizontalInput, 0, verticalInput);

        transform.Translate(walkDirection * Time.deltaTime);
    }
}
