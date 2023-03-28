using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectingRed : MonoBehaviour
{
    public PlayerController player;
    public Sprite[] basketSprites;

    public Image potionUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.redPoint <= 0)
        {
            potionUI.sprite = basketSprites[0];
        }
        else if (player.redPoint <= 1)
        {
            potionUI.sprite = basketSprites[1];
        }
        else if (player.redPoint <= 2)
        {
            potionUI.sprite = basketSprites[2];
        }
        else if (player.redPoint <= 3)
        {
            potionUI.sprite = basketSprites[3];
        }
        else if (player.redPoint <= 4)
        {
            potionUI.sprite = basketSprites[4];
        }
        else if (player.redPoint > 5)
        {
            potionUI.sprite = basketSprites[5];
        }
    }

}
