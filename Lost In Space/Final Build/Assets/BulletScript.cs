using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float velX = 5f;
    float velY = 0f;
    Rigidbody2D rb;


    //void OnCollisionEnter(Collision collision)
    //{
    //    GameObject.Destroy(gameObject);
    //}

    // public void OnCollisionEnter(Collision node)
    //{
    //   if (node.gameObject.tag == "Asteroid")
    //   {
    //        Destroy(node.gameObject);
    //    }
    // }

    /* void OnTriggerEnter(Collider col)
     {
         Destroy(col.gameObject);
     }

     void OnTriggerEnter()
     {
         Destroy(gameObject);
     } */
    /*void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }*/
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Asteroid")
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
