using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoDamageEnemy : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Player"))
        {
            TakeDamagePlayer.instance.TakeDamage(10);
        }
    }
}
