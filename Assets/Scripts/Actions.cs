using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Actions : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene("Subbeat");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Upgrade()
    {
        //SceneManager.LoadScene("Upgrade");
    }

    public void Music()
    {
        SceneManager.LoadScene("Music");
    }

}
