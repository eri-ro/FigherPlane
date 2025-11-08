using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : MonoBehaviour
{
    private float startX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 0.5f);

	float newX = startX + Mathf.Sin(Time.time * 2f) * 3f;
  	transform.position = new Vector3(newX, transform.position.y, transform.position.z);   

        if (transform.position.y < -5.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
