using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int layer = LayerMask.NameToLayer("objectpickup");
            if (Physics.Raycast(transform.position + transform.forward, transform.forward, 3.0f, 1 << layer))
            {
                
            }
        }
           
	}
}
