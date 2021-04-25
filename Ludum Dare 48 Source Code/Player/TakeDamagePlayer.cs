using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TakeDamagePlayer : MonoBehaviour
{
    public Rigidbody cam_rb;
    public float maxHealth = 100f;
    public float currhealth = 0f;

    public GameObject menu_pause;

    public static TakeDamagePlayer instance;

    public TextMeshProUGUI text;

    public GameObject weaponHolder;

    public static int score = 0;

    

    // Start is called before the first frame update
    void Start()
    {
        currhealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Health: " + currhealth + "/" + maxHealth;  
    }

   public void TakeDamage(int damage)
    {
        if (currhealth <= 0)
        {
            Destroy(gameObject);
            cam_rb.useGravity = true;
            weaponHolder.SetActive(false);
            menu_pause.SetActive(true);
        }

        currhealth -= damage;
        print(currhealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Enemy")
        {
            TakeDamage(10);
        }
    }
}
