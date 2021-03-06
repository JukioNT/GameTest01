using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialChest : MonoBehaviour
{
    public Sprite chestOpeningSprites;
    [HideInInspector]
    public bool colPlayer;
    [HideInInspector]
    public bool isOpend;
    private SpriteRenderer spriteR;

    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown("e") && colPlayer == true)
        {
            isOpend = true;
            Animation();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            colPlayer = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            colPlayer = false;
        }
    }

    void Animation()
    {
        spriteR.sprite = chestOpeningSprites;
    }
}
