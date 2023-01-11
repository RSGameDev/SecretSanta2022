using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueDisplay : MonoBehaviour
{
    public Dialogue dialogue;
    [SerializeField] private GameObject player;

    public GameObject pressPlay;
    public TextMeshProUGUI message;

    private Movement _movement;
    [SerializeField] private float timer;

    // Start is called before the first frame update
    private void Awake()
    {
        
    }

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        _movement = player.GetComponent<Movement>();
        message.text = dialogue.message;
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 4f)
        {
            pressPlay.SetActive(true);
        }
        
        if (Input.anyKeyDown)
        {
            _movement.PlayerCanMove();
            gameObject.SetActive(false);
        }
    }
}
