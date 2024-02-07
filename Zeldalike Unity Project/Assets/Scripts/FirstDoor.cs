using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDoor : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggered");
        PlayerMovement controller = other.GetComponent<PlayerMovement>();
        if(controller.key == 1)
        {

            Debug.Log("You may pass");
            controller.key--;
            
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Not enough keys");
        }
    }
}
