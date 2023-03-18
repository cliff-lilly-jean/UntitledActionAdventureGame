using UnityEngine;

public class Walk : MonoBehaviour
{
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 walkDirection = new Vector3(horizontalInput, 0, verticalInput);

        transform.Translate(walkDirection * Time.deltaTime);
    }
}
