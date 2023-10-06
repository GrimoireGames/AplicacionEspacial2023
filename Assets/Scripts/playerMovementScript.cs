using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float collisionCheckDistance = 0.1f;

    [SerializeField]private CapsuleCollider2D capsuleCollider;
    [SerializeField]private Animator animator;

    private void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f).normalized;

        // Check for collisions in the direction of movement
        if (movement.magnitude > 0f)
        {
            Vector3 collisionCheckPosition = transform.position + movement * collisionCheckDistance;
            Collider2D[] colliders = Physics2D.OverlapCapsuleAll(collisionCheckPosition, capsuleCollider.size, CapsuleDirection2D.Vertical, 0f);
            foreach (Collider2D collider in colliders)
            {
                if (collider.gameObject.tag == "Wall")
                {
                    // Stop movement if there is a wall in the way
                    movement = Vector3.zero;
                    break;
                }
            }
        }

        transform.position += movement * moveSpeed * Time.deltaTime;

        // Set animation parameters based on movement direction
        //animator.SetFloat("Horizontal", movement.x);
        //animator.SetFloat("Vertical", movement.y);
        //animator.SetFloat("Speed", movement.magnitude);

    }
}