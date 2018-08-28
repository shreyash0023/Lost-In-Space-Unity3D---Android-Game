using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class MoveScript : MonoBehaviour {

    float directionY;
    Rigidbody2D rb;

    public GameObject bulletToRight;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;

    void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.gameObject.tag == "Asteroid")
        //  {
        if (other.gameObject.tag == "Bullet") { }
        else
        {
            Destroy(gameObject);
            //SIGNAL GAME OVER HERE
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //}
        }
    }



    void Start()
    {
        // If you want the min max values to update if the resolution changes 
        // set them in update else set them in Start
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        directionY = CrossPlatformInputManager.GetAxis("Vertical");
        rb.velocity = new Vector2(0, directionY * 100);
        //CrossPlatformInputManager.GetButtonDown("Fire1");
        //if (Input.GetButtonDown("Fire1")&& Time.time > nextFire)
        //CrossPlatformInputManager.GetButtonDown("Shoot1");
        if (CrossPlatformInputManager.GetButtonDown("Shoot1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            fire();
        }
    }

    void fire()
    {
        bulletPos = transform.position;
        bulletPos += new Vector2(+1f, -0f);
        Instantiate(bulletToRight, bulletPos, Quaternion.identity);
    }
}
