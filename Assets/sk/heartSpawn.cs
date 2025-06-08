using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heartSpawn : MonoBehaviour
{
    public int heartcount = 0;
    public Text heartText;

    void Start()
    {
        
    }

    public void UpdateUI()
    {
        heartText.text = heartcount.ToString();
    }
}
