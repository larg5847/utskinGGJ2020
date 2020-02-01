using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour
{

    GameObject jugador;
    Vector3 separacionDeMovimiento;
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        Debug.Log(jugador.name);
        separacionDeMovimiento = this.transform.position - jugador.transform.position;
    }

    private void LateUpdate()
    {
        this.transform.position = jugador.transform.position + separacionDeMovimiento;
    }
}
