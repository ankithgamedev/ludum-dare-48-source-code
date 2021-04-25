using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TakeDamageEnemy : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currHealth = 0f;



    public static TakeDamageEnemy instance;

    [HideInInspector] public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
    }

    private void Update()
    {
        if (currHealth <= 0)
        {
            score += 1;
        }
    }

    public void TakeDamage(float damage){
        currHealth -= damage;
        print(currHealth);
        if (currHealth <= 0){
            Destroy(gameObject);
        }
    }
}
