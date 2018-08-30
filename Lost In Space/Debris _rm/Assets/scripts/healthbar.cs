using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour {
    Image healthBar;
    float maxHealth = 100f;
    public static float health;

    public float TotalHp;
    public float CurrentHp;

    // Use this for initialization
    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

        healthBar.fillAmount = health / maxHealth;

    }


    void TakeDamage()
    {

        CurrentHp -= 5;
        transform.localScale = new Vector3((CurrentHp / TotalHp), 1, 1);



    }
}
