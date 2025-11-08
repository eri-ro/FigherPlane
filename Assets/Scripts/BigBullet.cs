using UnityEngine;

public class BigBullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //make bullet move up
        transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * 6f);
        if (transform.position.y > 5.5f)
        {
            Destroy(this.gameObject);
        }

    }
}