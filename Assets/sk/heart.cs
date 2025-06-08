using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D obj_collider)
    {
        if (obj_collider.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            GameObject.Find("heartSpawn").GetComponent<heartSpawn>().heartcount++;
            GameObject.Find("heartSpawn").GetComponent<heartSpawn>().UpdateUI();
        }
         
    }
}
