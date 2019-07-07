using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mazegenerate : MonoBehaviour {
    public GameObject Mazewall;

    public int x, z;
    public int width = 50, height = 50, luck = 15, range = 5;

    public int rotationAmplitude = 10;
    public float[] colorRangeRed = {0, 1};
    public float[] colorRangeGreen = {0, 1};
    public float[] colorRangeBlue = {0, 1};

    public Vector3 scaleRangeMin;
    public Vector3 scaleRangeMax;

	// Use this for initialization
	void Start () {
		for(int x = 0; x < width; x++)
            for (int y = 0; y < height; y++)
            {
                if (x == width / 2 && y == height / 2) continue;

                if(Random.Range(0, luck) < range)
                {
                    GameObject wall = Instantiate(Mazewall);
                    wall.transform.localScale = new Vector3(Random.Range(scaleRangeMin.x, scaleRangeMax.x), Random.Range(scaleRangeMin.y, scaleRangeMax.y), Random.Range(scaleRangeMin.z, scaleRangeMax.z));
                    wall.transform.position = new Vector3(this.x - this.width + x * wall.transform.lossyScale.x, 61, this.z - this.height + y * wall.transform.lossyScale.z);
                    wall.transform.SetParent(transform);
                    wall.transform.rotation = Quaternion.Euler(Random.Range(-rotationAmplitude, rotationAmplitude), Random.Range(-rotationAmplitude, rotationAmplitude), Random.Range(-rotationAmplitude, rotationAmplitude));
                    wall.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(colorRangeRed[0], colorRangeRed[1]), Random.Range(colorRangeGreen[0], colorRangeGreen[1]), Random.Range(colorRangeBlue[0], colorRangeBlue[1]));
                }
            }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
