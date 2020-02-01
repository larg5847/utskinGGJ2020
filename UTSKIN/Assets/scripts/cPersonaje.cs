using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cPersonaje : MonoBehaviour
{

    Vector3 direccion;
    int cantBalas = 20;

    public Joystick mov;
    public Joystick dir;
    

    int velocidad = 5;
    float rot=0.0f;
    // Start is called before the first frame update
    void Start()
    {
        direccion = this.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        movimientoJugador();
        rotacionJugador();
        disparando();
    }

    private void movimientoJugador()
    {
        direccion = new Vector3(mov.Horizontal, mov.Vertical);
        direccion *= velocidad * Time.deltaTime;
        this.transform.position += direccion;
        
    }

    private void rotacionJugador()
    {
        float z = dir.Horizontal * 300;   
        rot -= Mathf.Round(z) * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    public void disparando()
    {

        cantBalas -= 1;
    }
}
