using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private SpriteRenderer m_Head;
    [SerializeField] private SpriteRenderer m_Body;
    [SerializeField] private SpriteRenderer m_Legs;
    [SerializeField] private SpriteRenderer m_Weapon;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Assert(m_Head, "Head missing from player prefab.");
        Debug.Assert(m_Body, "Body missing from player prefab.");
        Debug.Assert(m_Legs, "Legs missing from player prefab.");
        Debug.Assert(m_Weapon, "Weapon missing from player prefab.");
    }

    public void SetHead(Sprite head) { m_Head.sprite = head; }
    public void SetBody(Sprite body) { m_Body.sprite = body; }
    public void SetLegs(Sprite legs) { m_Legs.sprite = legs; }
    public void SetWeapon(Sprite weapon) { m_Weapon.sprite = weapon; }
}
