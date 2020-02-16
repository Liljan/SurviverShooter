using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D m_RigidBody;
    [SerializeField] private Animator m_LegsAnimator;

    [SerializeField] private float m_Speed;
    private float m_CurrentSpeed;

    private void OnEnable()
    {
        Debug.Assert(m_RigidBody, "No rigidbody2d assigned to PlayerMovement script");
        Debug.Assert(m_LegsAnimator, "No animator attached to player legs");
        m_CurrentSpeed = 0.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxis("Horizontal");
        float movementY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(movementX, movementY);
        movement.Normalize();

        m_RigidBody.velocity = m_Speed * movement;
    }
}
