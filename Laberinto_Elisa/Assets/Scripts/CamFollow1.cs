using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow1 : MonoBehaviour
{

    //Variable de tipo transform que está vinculada a la nave
    [SerializeField] Transform playerPosition;
    //Variables mov de la cámara
    [SerializeField] float distancia;
    [SerializeField] float altura;
    Vector3 cameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        distancia = 0.4f;
        altura = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        CamFol();
    }

    void CamFol()
    {
        //distancia = 6;
        cameraPosition = new Vector3(playerPosition.position.x, (playerPosition.position.y + altura), (playerPosition.position.z - distancia));
        transform.position = cameraPosition;
        transform.LookAt(playerPosition);
    }
}
