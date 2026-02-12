using UnityEngine;

public class Character2D : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 10f;
    public Transform shootPoint;

    public Pooling pooling;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.linearVelocity = Vector3.up 
                * jumpForce;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            pooling.CreateObject(shootPoint);
        }
    }
}
