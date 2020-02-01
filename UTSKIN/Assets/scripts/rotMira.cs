using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotMira : MonoBehaviour
{
    GameObject personajeEje;
    public Joystick dir;
    // Start is called before the first frame update
    void Start()
    {

        personajeEje = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(personajeEje.transform.position, new Vector3(0,0, -Mathf.Round(dir.Horizontal)), 100 * Time.deltaTime);
    }
}
