using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        healthbar.health -= 10f;
    }
}
