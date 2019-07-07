using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject bulletPrefab;

    // Use this for initialization
    void Start()
    {
        GetComponent<ShaderEffect_Tint>().y = Random.Range(0.5f, 1.5f);
        GetComponent<ShaderEffect_Tint>().u = Random.Range(0.36f, 1.5f);
        GetComponent<ShaderEffect_Tint>().v = Random.Range(-0.5f, 4f);



        if (GetComponent<ShaderEffect_Tint>().y == 0) GetComponent<ShaderEffect_Tint>().y = 1;
        if (GetComponent<ShaderEffect_Tint>().u == 0) GetComponent<ShaderEffect_Tint>().u = 1;
        if (GetComponent<ShaderEffect_Tint>().v == 0) GetComponent<ShaderEffect_Tint>().v = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.forward, Quaternion.identity);
            Rigidbody bulletRigidbody = (Rigidbody)bullet.GetComponent(typeof(Rigidbody));

            bulletRigidbody.AddForce(transform.forward * 1000.0f, ForceMode.Force);

        }

        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hitInfo;
            if (Physics.Raycast(transform.position + transform.forward, transform.forward, out hitInfo))
            {
                if (hitInfo.collider.gameObject.name == "Target")
                {
                    Destroy(hitInfo.collider.gameObject);
                }
            }
        }

    }
}