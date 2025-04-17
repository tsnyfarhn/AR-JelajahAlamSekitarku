using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoSungai : MonoBehaviour
{
    public void BackButton()
    {
        SceneManager.LoadScene("AR Scene");
    }

    public void HomeButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void NextButton()
    {
        SceneManager.LoadScene("Info Gunung");
    }

    public void PrevButton()
    {
        SceneManager.LoadScene("Info Pohon");
    }
}
