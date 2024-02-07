using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] public int health = 100;
    public void Damage(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }
        Debug.Log("Damaged");
        this.health -= amount;

        if(health <= 0)
        {
            Debug.Log("Call die");
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("Something died");
        if (gameObject.CompareTag("Player"))
        {
            Debug.Log("Player dead");
            SceneManager.LoadScene("LoseScene");
        }
        else if(gameObject.CompareTag("Boss"))
        {
            Debug.Log("Boss is dead");
            Debug.Log("Game won");
            SceneManager.LoadScene("WinScene");
        }
        else
        {
            Debug.Log("This thing is dead");
            Destroy(gameObject);
        }

    }
}
