using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrenoMove : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] float fuerza;
    // Start is called before the first frame update
    void Start()
    {
        fuerza = 5.5f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        //usa el vector manual en lugar de .right para permir que el módulo no sea unitario, por lo que la fuerza será menor/más suave
        Girar();
    }

    void Girar()
    {
        //mov eje X
        float desplX = Input.GetAxis("Horizontal") * fuerza;
        // transform.Translate(Vector3.right * desplX * Time.deltaTime);
        rb.AddTorque(new Vector3(0.2f, 0, 0) * desplX);
        //mov eje Y
        float desplZ = Input.GetAxis("Vertical") * fuerza;
        //transform.Translate(Vector3.forward * desplZ * Time.deltaTime);
        rb.AddTorque(new Vector3(0, 0, 0.2f) * desplZ);
    }
}
