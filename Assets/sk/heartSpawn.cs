using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class heartSpawn : MonoBehaviour
{
    public int heartcount = 0;
    public Text heartText;
    public int maxHeart;
    void Start()
    {
        maxHeart = GameObject.FindGameObjectsWithTag("heart").Length;
    }

    public void UpdateUI()
    {
        if (heartcount >= maxHeart)
        {
            if (SceneManager.GetActiveScene().buildIndex > SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                SceneManager.LoadScene("menu");
            }
        }
        heartText.text = heartcount.ToString();
    }
}
