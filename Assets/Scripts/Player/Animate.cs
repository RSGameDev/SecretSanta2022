using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    public BoxCollider weapon;
    
    // Start is called before the first frame update
    void Start()
    {
        weapon.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            gameObject.GetComponent<Animator>().Play(("Attack02_SwordAndShiled1"));
        }
    }

    void ToggleWeaponCollider()
    {
        print("toggle weapon");
        switch (weapon.enabled)
        {
            case false:
                weapon.enabled = true;
                break;
            default:
                weapon.enabled = false;
                break;
        }
    }
    
    
}
