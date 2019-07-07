using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene1 : MonoBehaviour

{
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            RenderSettings.ambientLight = Color.white;
            SceneManager.LoadScene(2);

        }

    }
}
