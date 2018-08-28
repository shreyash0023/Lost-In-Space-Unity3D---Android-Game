using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class AiScript : MonoBehaviour {

    double directionY;
    Rigidbody2D rb;

    public GameObject AI_bullet;
    public GameObject player_ship;
    public GameObject AIship;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;

    //System.Random rand = new System.Random();
    float player_pos = 0.0f;
    public float moveRate = 0.5f;
    float nextMove = 0.0f;


    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Bullet")
        {
            AIship.SetActive(false);
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();

	}
	

	// Update is called once per frame
	void Update () {
       

        if (Time.time > nextMove)
        {
            nextMove = Time.time + moveRate;
            if (player_ship.transform.position.y > rb.transform.position.y)
            {
                directionY += 0.1;
                rb.velocity = new Vector2(0, (float)directionY * 100);
            }
            else if (player_ship.transform.position.y <= rb.transform.position.y)
            {
                directionY -= 0.1;
                rb.velocity = new Vector2(0, (float)directionY * 100);
            }
            
        }
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            fire();
        }
        
    }

    void fire()
    {
        bulletPos = transform.position;
        bulletPos += new Vector2(+1f, -0f);
        Instantiate(AI_bullet, bulletPos, Quaternion.identity);
    }
}
