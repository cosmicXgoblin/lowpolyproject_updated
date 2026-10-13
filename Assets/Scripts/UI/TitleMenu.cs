using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Only for the function of the title menu.
/// Due to lowpolyisland being my first project with unity, i didn't implement a general GameManager and after disposing a lot of not finished code 
/// or things where i played around, only the basics were remaining.
/// </summary>

public class TitleMenu : MonoBehaviour
{
    public Image fadeImage;


    public void OnClickStartGame()
    {
        SoundEffectManager.Play("Button");
        StartCoroutine(FadeToScene(3));
    }

    public void OnClickQuitGame()
    {
        SoundEffectManager.Play("Button");
        Application.Quit();
    }

    IEnumerator FadeToScene(float duration)
    {
        float t = 0;
        Color c = fadeImage.color;

        while (t < duration)
        {
            t += Time.deltaTime;
            c.a = t / duration;
            fadeImage.color = c;
            yield return null;
        }

        SceneManager.LoadScene(1);
    }



}
