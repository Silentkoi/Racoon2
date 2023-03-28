using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fry : MonoBehaviour
{

    
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerCharacter");
    }

   void OnCollsionEnter(Collision collision)
   {
          Debug.Log("Work");

   }

    private void OnTriggerEnter(Collider collision)
    {
       if (collision.tag == "Player")
       {

            
            Destroy(gameObject);
            Debug.Log("Collected");
            player.GetComponent<PlayerController>().redPoint++;

       }  
    }

}
