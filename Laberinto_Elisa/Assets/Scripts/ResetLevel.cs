using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Reset();
    }

    private void Reset()
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;
        if (transform.position.y < -0.15)
        {
            print("Ostia terrible");
            SceneManager.LoadScene(actualScene); 

        }
    }
}
