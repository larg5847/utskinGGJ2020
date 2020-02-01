using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cPersonaje : MonoBehaviour
{

    Vector2 direccion;
    int cantBalas = 20;

    public Joystick mov;
    //public Joystick dir;
    Rigidbody2D rbJugador;
    int velocidad = 20;
    //float rot=0;
    GameObject finMira;
    // Start is called before the first frame update
    void Start()
    {
        //direccion = this.GetComponent<Transform>().position;
        rbJugador = this.GetComponent<Rigidbody2D>();
        finMira = GameObject.Find("FinDisparo");
    }

    // Update is called once per frame
    void Update()
    {
        movimientoJugador();
        disparando();


        
    }

    private void FixedUpdate()
    {
        rbJugador.MovePosition(rbJugador.position + direccion * velocidad * Time.deltaTime);


       

        
    }

    private void movimientoJugador()
    {
        direccion = new Vector2(mov.Horizontal, mov.Vertical);
        //direccion *= velocidad * Time.deltaTime;
        //this.transform.position += direccion;
    }

    /*private void rotacionJugador()
    {
        float z = dir.Horizontal * 300;
        rot = Mathf.Round(z) * Time.deltaTime;

    }*/

    public void disparando()
    {
        cantBalas -= 1;
    }
}
