using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
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
        var scaleChange = new Vector3(gameObject.transform.localScale.x, gameObject.transform.localScale.y/2, gameObject.transform.localScale.z);
        gameObject.transform.localScale = scaleChange;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("sword"))
        {
            print("hitting grass");
            CutDown();
        }
    }
}
