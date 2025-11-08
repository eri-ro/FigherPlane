using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -2, 0) * Time.deltaTime * 3f);
        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
