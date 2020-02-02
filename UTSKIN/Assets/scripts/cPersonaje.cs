using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cPersonaje : MonoBehaviour
{

    Vector2 direccion;
    int cantBalas = 20;

    public Joystick mov;
    Rigidbody2D rbJugador;
    int velocidad = 20;
    GameObject finMira;
    // Start is called before the first frame update
    void Start()
    {
        rbJugador = this.GetComponent<Rigidbody2D>();
        finMira = GameObject.Find("FinDisparo");
    }

    // Update is called once per frame
    void Update()
    {
        movimientoJugador();
    }

    private void FixedUpdate()
    {
        rbJugador.MovePosition(rbJugador.position + direccion * velocidad * Time.deltaTime);
    }

    private void movimientoJugador()
    {
        direccion = new Vector2(mov.Horizontal, mov.Vertical);
    }
    
    public void disparando()
    {
        cantBalas -= 1;
    }
}
