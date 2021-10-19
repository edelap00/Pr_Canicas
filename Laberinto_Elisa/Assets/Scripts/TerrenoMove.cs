using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrenoMove : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddTorque(new Vector3(0, 0, 0.5f));  
        //usa el vector manual en lugar de .right para permir que el módulo no sea unitario, por lo que la fuerza será menor/más suave
    }
}
