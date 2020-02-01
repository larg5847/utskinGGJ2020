using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserAttack : MonoBehaviour
{

    //LineRenderer line;
    GameObject finLinea;
    
    // Start is called before the first frame update
    void Start()
    {
        /*line = GetComponent<LineRenderer>();
        line.enabled = true;
        line.useWorldSpace = true;
        */
        finLinea = GameObject.Find("FinDisparo");

        Debug.Log(transform.position + "     " + finLinea.transform.position);

    }


    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, finLinea.transform.position);
        if (hit.collider != null)
        {
            //code when the ai can walk
            Debug.Log("no pego");
        }
        else
        {
            Debug.Log("si pego");
            //code when the ai cannot walk
        }
    }

    // Update is called once per frame
    void Update()
    {
         
    }


    public void ataque()
    {

    }
}
