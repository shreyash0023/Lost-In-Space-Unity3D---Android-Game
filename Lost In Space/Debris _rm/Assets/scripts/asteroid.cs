using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour {

    public float maxthrust;
    public float maxtorque;
    public Rigidbody2D rb;
    public float screenLeft;
    public float screenTop;
    public float screenBottom;
    public float screenRight;
   

	// Use this for initialization
	void Start () {
        // Add a random amount of troque and thrust to the asteroid
        Vector2 thrust = new Vector2(Random.Range(-maxthrust,0), Random.Range(-maxthrust,0));
        float torque = Random.Range(-maxtorque,maxtorque);


        rb.AddForce(thrust);
        rb.AddTorque(torque);


	}
	
	// Update is called once per frame
	void Update () {

        Vector2 newPos = transform.position;
        if (transform.position.y > screenTop)
        {
            newPos.y = screenBottom;

        }
        if (transform.position.y < screenBottom)
        {
            newPos.y = screenTop;

        }
        if (transform.position.x > screenRight)
        {
            newPos.x = screenLeft;

        }
        if (transform.position.x < screenLeft)
        {
            newPos.x = screenRight;

        }

        transform.position = newPos;

    }
}
