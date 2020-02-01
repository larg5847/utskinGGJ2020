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

    float rot=0;
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
        this.transform.RotateAround(transform.position,Vector3.back,rot*Time.deltaTime);

        
        /*float z = dir.Horizontal;
        float x = dir.Vertical;
        float rotacion = 0.0f;
        //Debug.Log(x + "    " + z);

        rotZ =  (int)Mathf.Round(z);
        rotX = (int)Mathf.Round(x);
        
        Debug.Log(rotX + "    " + rotZ);
        if(rotZ == 1 && rotacion!=-90.0f)
        {
            rotacion = -90.0f;
            this.transform.Rotation = new Vector3(0,0,rotacion);
        }*/
    }

    public void disparando()
    {
        cantBalas -= 1;
    }
}
