using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLossDisplay : MonoBehaviour
{
    public Image winDisplay;
    private bool isWinDisplayed;
    public Image lossDisplay;
    private bool isLossDisplayed;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void ShowWinDisplay()
    {
        if (!isWinDisplayed)
        {
            isWinDisplayed = true;
            winDisplay.gameObject.SetActive(true);
        }
        else
        {
            isWinDisplayed = false;
            winDisplay.gameObject.SetActive(false);
        }
    }
    
    void ShowLossDisplay()
    {
        if (!isLossDisplayed)
        {
            isLossDisplayed = true;
            lossDisplay.gameObject.SetActive(true);
        }
        else
        {
            isLossDisplayed = false;
            lossDisplay.gameObject.SetActive(false);
        }
    }
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            ShowWinDisplay();
        }   
        
        if (Input.GetKeyDown(KeyCode.L))
        {
            ShowLossDisplay();
        }  
    }
}
