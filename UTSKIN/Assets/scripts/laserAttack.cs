using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserAttack : MonoBehaviour
{

    LineRenderer line;
    Transform laserH;
    bool activado = false;
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.enabled = false;
        line.useWorldSpace = true;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up);
        laserH.position = hit.point;
        line.SetPosition(0, transform.position);
        line.SetPosition(1, laserH.position);
        if(activado == true)
        {
            line.enabled = true;
        }
        else
        {
            line.enabled = false;
        }
    }
    public void ataque()
    {

    }
}
