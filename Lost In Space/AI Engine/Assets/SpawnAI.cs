using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAI : MonoBehaviour {


    public GameObject AIship;
    public Transform spawnPoint;
    float nextSpawn = 0.0f;
    //private float time;


    // Use this for initialization
    void Start () {

        Invoke("Spawning", 100);
    }
	
	// Update is called once per frame
	void Update () {

    }

    void Spawning()
    {
        Instantiate(AIship, spawnPoint.position, spawnPoint.rotation);
    }
}