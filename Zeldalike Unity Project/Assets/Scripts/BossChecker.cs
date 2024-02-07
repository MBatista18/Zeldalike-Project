using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossChecker : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggered");
        PlayerMovement controller = other.GetComponent<PlayerMovement>();
        if(controller.key == 1)
        {

            Debug.Log("You may pass");
            controller.key--;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            Debug.Log("Not enough keys");
        }
    }
}
