using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Swithc : MonoBehaviour
{
    public void Restart()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentLevel);
    }
    
    public void NextLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        if (currentLevel < 1)
        {
            SceneManager.LoadScene(currentLevel + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }

    }
}
