using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrenoMove : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] float fuerza;
    [SerializeField] float limRight = 0.15f;
    [SerializeField] float limLeft = -0.15f;
    [SerializeField] float limUp = 0.15f;
    [SerializeField] float limDown = -0.15f;
    bool inLimitX;
    [SerializeField] bool inLimitZ = true;
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
       // transform.rotation.y = new Vector3((transform.rotation.x, 0, transform.rotation.z));
       //mov ejes
        float desplX = Input.GetAxis("Horizontal") * fuerza; 
        float desplZ = Input.GetAxis("Vertical") * fuerza;

        //código para restricción

        float rotX = transform.rotation.x;
        float rotZ = transform.rotation.z;

        if (rotX >= limRight && desplX > 0 || rotX <= limLeft && desplX < 0)
        {
            inLimitX = false;
        }
        else { inLimitX = true; }

        if (inLimitX)
        {
            //mov eje X
           
            // transform.Translate(Vector3.right * desplX * Time.deltaTime);
            rb.AddTorque(new Vector3(0.2f, 0, 0) * desplX);
        }

        if (rotZ >= limUp && desplZ > 0 || rotZ <= limDown && desplZ < 0)
        {
            inLimitZ = false;
        }
        else { inLimitZ = true; }

        if (inLimitZ)
        {
            //mov eje Z
           
            //transform.Translate(Vector3.forward * desplZ * Time.deltaTime);
            rb.AddTorque(new Vector3(0, 0, 0.2f) * desplZ);
        }

       
    }
}
