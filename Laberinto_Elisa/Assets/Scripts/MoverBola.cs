using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MoverBola : MonoBehaviour
{

    //variables
    [SerializeField] float fuerza;
    public Rigidbody rb;
  
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        fuerza = 3f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Desplazamiento();
     
     
    }

    void Desplazamiento()
    {

        //mov eje X
        float desplX = Input.GetAxis("Horizontal") * fuerza;
        // transform.Translate(Vector3.right * desplX * Time.deltaTime);
        rb.AddForce(Vector3.right * desplX);
        //mov eje Y
        float desplZ = Input.GetAxis("Vertical") * fuerza;
        //transform.Translate(Vector3.forward * desplZ * Time.deltaTime);
        rb.AddForce(Vector3.forward * desplZ);

    }

}