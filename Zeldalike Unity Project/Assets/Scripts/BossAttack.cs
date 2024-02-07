using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    private int damage = 5;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Health>() != null)
        {
            Health playerHealth = collider.GetComponent<Health>();
            playerHealth.Damage(damage);
        }
    }
}