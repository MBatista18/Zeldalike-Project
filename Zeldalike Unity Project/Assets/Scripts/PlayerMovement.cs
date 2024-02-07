using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public int health = 12
    public int key;
    public float speed;
    private Rigidbody2D playerRigidbody;
    private Vector3 change;
    private Animator animator;
    public AudioClip keyCollected;
    AudioSource audioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        playerRigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if(change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }

    void MoveCharacter()
    {
        playerRigidbody.MovePosition(
                transform.position + change * speed * Time.deltaTime * 2.0f
            );
    }



    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
