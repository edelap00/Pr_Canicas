using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        int actualScene = SceneManager.GetActiveScene().buildIndex;

        if (other.gameObject.name == "canica")
        {
            print("dentro");
            actualScene++;
          // int  actual = SceneManager.GetActiveScene;
           SceneManager.LoadScene(actualScene);
        }
        
    }
}
