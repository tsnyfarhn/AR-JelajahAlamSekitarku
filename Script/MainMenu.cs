using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour // Membuat function baru
{
    public void Mulai() // Mendeklarasikan Class Mulai
    {
        SceneManager.LoadScene("AR Scene"); // Pindah Ke Menu AR
    }

    public void Petunjuk() // Mendeklarasikan Class Mulai
    {
        SceneManager.LoadScene("Petunjuk"); // Pindah Ke Menu Petunjuk
    }

    public void TentangApp() // Mendeklarasikan Class Mulai
    {
        SceneManager.LoadScene("Tentang App"); // Pindah Ke Menu Tentang App
    }
}
