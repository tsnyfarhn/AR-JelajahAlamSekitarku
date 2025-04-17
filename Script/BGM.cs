using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM : MonoBehaviour // Membuat function baru
{
    private void Awake() // Mendeklarasikan variable baru
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("BGM"); // Mencari game object ber tag BGM
        if( musicObj.Length > 1) // Jika musik lebih dari 1 maka melakukan destroy
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject); // Jika tidak akan tidak mendestroy
    }
}
