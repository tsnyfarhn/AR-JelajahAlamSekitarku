using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAnimation : MonoBehaviour
{
    public float speedX = 0.1f; // membuat berapa kecepatan speed x berdasarkan 0.1 float
    public float speedY = 0.1f; // membuat berapa kecepatan speed y berdasarkan 0.1 float
    private float curX; // Membuat definisi variable curX
    private float curY; // Membuat definisi variable curY

    // Use this for initialization
    void Start() 
    {
        curX = GetComponent<Renderer>().material.mainTextureOffset.x; // Mendefinisikan curX
        curY = GetComponent<Renderer>().material.mainTextureOffset.y; // Mendefinisikan curY
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        curX += Time.deltaTime * speedX; // membuat curX lebih dari time.deltatime dikali speedX
        curY += Time.deltaTime * speedY; // membuat curY lebih dari time.deltatime dikali speedY
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(curX, curY)); 
    }
}
