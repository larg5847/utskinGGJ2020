using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserAttack : MonoBehaviour
{

    LineRenderer line;
    GameObject finLinea;

    Vector2 thisPos;
    Vector2 finalPos;

    CircleCollider2D circuloAtacante;

    bool estaAtacando = false;
    // Start is called before the first frame update
    void Start()
    {
        finLinea = GameObject.Find("FinDisparo");
        line = GetComponent<LineRenderer>();
        circuloAtacante = finLinea.GetComponent<CircleCollider2D>();
    }


    void FixedUpdate()
    {
        //var hit : RaycastHit;
        

    }

    // Update is called once per frame
    void Update()
    {
        if(estaAtacando)
        {
            finalPos = finLinea.transform.position;
            thisPos = this.transform.position;
            var hit = Physics2D.Linecast(thisPos, finalPos, 1 << LayerMask.NameToLayer("Oxido"));
            Debug.DrawLine(thisPos, finalPos);

            line.SetWidth(.2f,.01f);
            line.SetPosition(0, thisPos);
            line.SetPosition(1, finalPos);
            //SetColor(Color.blue, Color.red);


        }
        
    }

    public void activarAtaque()
    {
        estaAtacando = true;
        line.enabled = true;
        circuloAtacante.enabled = true;
    }
    public void desactivarAtaque()
    {
        estaAtacando = false;
        line.enabled = false;
        circuloAtacante.enabled = false;
    }
}
