using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private Animator anim;
    public float speed = 1f;
    private float playerMovement;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void Update()
    {
        playerMovement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        if (playerMovement > 0.1f || playerMovement < -0.1f)
        {
            rb.AddForce(new Vector2(playerMovement * speed, 0f), ForceMode2D.Impulse);
        }

        AnimationUpdate();
    }

    private void AnimationUpdate()
    {
        if (playerMovement != 0f)
        {
            anim.SetBool("running", true);
        }
        else
        {
            anim.SetBool("running", false);
        }
    }
}
