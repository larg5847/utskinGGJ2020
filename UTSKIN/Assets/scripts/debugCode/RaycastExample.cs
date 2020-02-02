using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastExample : MonoBehaviour
{
    public float floatHeight;     // Desired floating height.
    public float liftForce;       // Force to apply when lifting the rigidbody.
    public float damping;         // Force reduction proportional to speed (reduces bouncing).

    Rigidbody2D rb2D;

    GameObject v;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        v = GameObject.Find("jugador");
    }

    void FixedUpdate()
    {
        // Cast a ray straight down.
        

        Debug.DrawLine(this.transform.position, v.transform.position, Color.blue);
       

        if (Physics2D.Linecast(this.transform.position, v.transform.position,8))
        {
            Debug.Log("se toco paredes");
        }
        if (Physics2D.Linecast(this.transform.position, v.transform.position, 9))
        {
            Debug.Log("se toco Oxido");
        }



        // If it hits something...

    }
}
