using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] private GameObject m_Reticle;

    // Temporary
    [SerializeField] private float m_AimRadius;

    private void OnEnable()
    {
        Debug.Assert(m_Reticle, "No reticle gameobjects attached to the player weapon");
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        HandleAim();
    }

    private void HandleAim()
    {
        Vector2 worldPoint = Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));

        Vector2 center = gameObject.transform.position;
        Vector2 direction = worldPoint - center;
        direction.Normalize();

        Vector2 aimPoint = center + direction * m_AimRadius;
        float reticleZ = m_Reticle.transform.position.z;

        m_Reticle.transform.position = new Vector3(aimPoint.x, aimPoint.y, reticleZ);     
    }
}
