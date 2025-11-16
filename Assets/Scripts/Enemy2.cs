using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public GameObject explosionPrefab;
     private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -2, 0) * Time.deltaTime * 3f);
        if (transform.position.y < -5.5f)
        {
            Destroy(this.gameObject);
        }
    }
        private void OnTriggerEnter2D(Collider2D whatDidIHit)
    {
        if(whatDidIHit.tag == "Player")
        {
            whatDidIHit.GetComponent<PlayerController>().LoseALife();
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        } else if(whatDidIHit.tag == "Weapons")
        {
            Destroy(whatDidIHit.gameObject);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            gameManager.AddScore(10);
            Destroy(this.gameObject);
        }
    }
}
