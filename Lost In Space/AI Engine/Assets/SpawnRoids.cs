using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRoids : MonoBehaviour {

    public Transform[] SpawnPoints;

    public float spawnTime = 1.5f;

    public GameObject Asteroids;
    public GameObject AIShip;
    int flag = 0;

    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawning", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
       /* 
        if (AIShip.activeSelf)
        {
            CancelInvoke("Spawning");
            flag = 0;
        }
        else if(!AIShip.activeSelf)
        {
            if(flag == 0)
            {
                InvokeRepeating("Spawning", spawnTime, spawnTime);
            }
            flag = 1;
        }
        */
    }

    void Spawning()
    {
        int spawnIndex = Random.Range(0, SpawnPoints.Length);
        Instantiate(Asteroids, SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
    }

}
