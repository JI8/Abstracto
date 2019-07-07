using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalgenerate : MonoBehaviour
{
    public GameObject portal;

    public int x, z;
    public int width = 50, height = 50, luck = 15, range = 5;

    public int rotationAmplitude = 10;


    public Vector3 scaleRangeMin;
    public Vector3 scaleRangeMax;

    // Use this for initialization
    void Start()
    {
        for (int x = 0; x < width; x++)
            for (int y = 0; y < height; y++)
            {
                if (x == width / 2 && y == height / 2) continue;

                if (Random.Range(0, luck) < range)
                {
                    GameObject wall = Instantiate(portal);
                    wall.transform.localScale = new Vector3(Random.Range(scaleRangeMin.x, scaleRangeMax.x), Random.Range(scaleRangeMin.y, scaleRangeMax.y), Random.Range(scaleRangeMin.z, scaleRangeMax.z));
                    wall.transform.position = new Vector3(this.x - this.width + x * wall.transform.lossyScale.x, 61, this.z - this.height + y * wall.transform.lossyScale.z);
                    wall.transform.SetParent(transform);
                    wall.transform.rotation = Quaternion.Euler(Random.Range(-rotationAmplitude, rotationAmplitude), Random.Range(-rotationAmplitude, rotationAmplitude), Random.Range(-rotationAmplitude, rotationAmplitude));
                    
                }
            }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
