using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void gotoLevel()
    {
        SceneManager.LoadScene("level1");
    }

      public void gotoLevel2()
    {
        SceneManager.LoadScene("level2");
    }
}
