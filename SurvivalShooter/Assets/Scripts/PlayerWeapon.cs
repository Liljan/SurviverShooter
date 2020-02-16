using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] private Transform m_Reticle;
    [SerializeField] private Transform m_Body;

    [SerializeField] private uint m_RotationSegments;

    // Temporary
    [SerializeField] private float m_AimRadius;

    private void OnEnable()
    {
        Debug.Assert(m_Reticle, "No reticle transform attached to the player weapon.");
        Debug.Assert(m_Body, "No body transform attached to the player.");
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        HandleAim();
        RotateCharacter();
    }

    private void HandleAim()
    {
        Vector2 worldPoint = Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));

        Vector2 center = gameObject.transform.position;
        Vector2 direction = worldPoint - center;
        direction.Normalize();

        Vector2 aimPoint = center + direction * m_AimRadius;
        float reticleZ = m_Reticle.position.z;

        m_Reticle.position = new Vector3(aimPoint.x, aimPoint.y, reticleZ);
    }

    private void RotateCharacter()
    {
        Vector2 direction = m_Reticle.position - gameObject.transform.position;
        direction.Normalize();

        float angle = -Vector2.SignedAngle(direction, -gameObject.transform.up);

        m_Body.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
    }
}
