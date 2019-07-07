using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadlastscene : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider other)
    {

        //tag your player "Player" 
        if (GetComponent<Collider>().tag == "Player")
        {

            //"scene" this is a name of level to load
            Application.LoadLevel("Heaven");

        }
    }

}
