using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public HUD hudScript;
    //public delegate void LandScaped();
    //public static event LandScaped GrassCut;
    
    private int moneyEarned;
    
    // Start is called before the first frame update
    void Start()
    {
      //terrainLandscaped.AddListener(GrassCut);  
    }

    public void Income()
    {
        moneyEarned += 50;
    }

    void currentEarnings()
    {
        hudScript.AddIncome(moneyEarned);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    
    
}
