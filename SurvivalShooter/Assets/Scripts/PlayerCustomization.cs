using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCustomization : MonoBehaviour
{
    [SerializeField] private Player m_Player;

    [SerializeField] private Sprite[] m_Heads;
    [SerializeField] private Sprite[] m_Bodies;
    [SerializeField] private Sprite[] m_Legs;
    [SerializeField] private Sprite[] m_Weapons;

    private void OnEnable()
    {
        m_Player.SetHead(m_Heads[0]);
        m_Player.SetBody(m_Bodies[0]);
        m_Player.SetLegs(m_Legs[0]);
        m_Player.SetWeapon(m_Weapons[0]);
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("r"))
        {
            m_Player.SetHead(m_Heads[Random.Range(0, m_Heads.Length)]);   
            m_Player.SetBody(m_Bodies[Random.Range(0, m_Bodies.Length)]);
            //m_Player.SetLegs(m_Legs[Random.Range(0, m_Legs.Length)]);
            m_Player.SetWeapon(m_Weapons[Random.Range(0, m_Weapons.Length)]);
        }
    }
}
