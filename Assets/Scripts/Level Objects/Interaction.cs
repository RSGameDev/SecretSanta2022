using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public ScoreManager scoreManagerScript;
    public Collider _colliderHitBox;
    //public Collider _colliderBlock;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void CutDown()
    {
        var localScale = gameObject.transform.localScale;
        var scaleChange = new Vector3(localScale.x, localScale.y-2.8f, localScale.z);
        gameObject.transform.localScale = scaleChange;
        DisableCollider();
        scoreManagerScript.Income();

    }
    void DisableCollider()
    {
        _colliderHitBox.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("sword"))
        {
            print("hitting grass");
            CutDown();
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("sword"))
    //    {
    //        print("hitting grass");
    //        CutDown();
    //    }
    //}
}
