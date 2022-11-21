using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    public Button StartBtn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SBtn() 
    {
        SceneManager.LoadScene("2");
    }
}
