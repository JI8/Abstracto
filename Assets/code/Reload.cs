using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour

{
    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            RenderSettings.ambientLight = Color.white;
            SceneManager.LoadScene("Heaven");
            
        }

    }
}



