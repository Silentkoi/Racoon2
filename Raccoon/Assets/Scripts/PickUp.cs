using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    //private bool pickUpAllowed;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame

    private void Update()
    {
        //if (pickUpAllowed && Input.GetKeyDown(KeyCode.Q))
        
           
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
      if (collision.tag == "Player")
        {
           // pickUpAllowed = true;
            Destroy(gameObject);
            Debug.Log("Collected");
            player.GetComponent<PlayerController>().redPoint++;

        }
    }



}