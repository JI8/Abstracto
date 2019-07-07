using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour {

    public float life = 5;
    private float time;
	
	void Update () {
        time += Time.deltaTime;

        if (time > life) gaDood();
	}

    void gaDood()
    {
        //particles hier doen Madchiel dit knanj ei 3rowejwilbsdilsewbl
        Destroy(gameObject);

    }
}
