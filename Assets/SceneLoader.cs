using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader _instance;
    private int sceneValue = 0;
    private Scene currentScene;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        // if (SceneManager.GetActiveScene().buildIndex != 0)
        // {
        //     Time.timeScale = 0f;
        // }
    }

    void UnPause()
    {
        Time.timeScale = 1f;
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            UnPause();
        }
    }
    
    
    
    
}
