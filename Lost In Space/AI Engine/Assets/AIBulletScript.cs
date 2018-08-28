using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIBulletScript : MonoBehaviour {
    public float velX = 5f;
    float velY = 0f;
    Rigidbody2D rb;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            Destroy(gameObject);
        else
        { }
    }
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(velX, velY);
        Destroy(gameObject, 5f);
    }
}
