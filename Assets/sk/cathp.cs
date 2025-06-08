using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class cathp : MonoBehaviour
{
    public int hp = 3;
    public Text hpText;
    private void Start() {
        UpdateUI();
    }
    public void UpdateUI()
    {
        hpText.text = hp.ToString();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("spike"))
        {
            hp = hp - 1;
            if (hp <= 0)
            {
                SceneManager.LoadScene("menu");
            }
            UpdateUI();
        }
    }
}
