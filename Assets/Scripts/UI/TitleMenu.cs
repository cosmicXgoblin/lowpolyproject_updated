using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Only for the function of the title menu.
/// Due to lowpolyisland being my first project with unity, i didn't implement a general GameManager and after disposing a lot of not finished code 
/// or things where i played around, only the basics were remaining.
/// </summary>

public class TitleMenu : MonoBehaviour
{
    public void StartGame()
    {
        SoundEffectManager.Play("Button");
        // #To-Do: Verzögerung!
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        SoundEffectManager.Play("Button");
        Application.Quit();
    }
}
