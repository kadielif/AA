using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anamenuKontrol : MonoBehaviour
{
    void Start()
    {
        //PlayerPrefs.DeleteAll();
    }
    public void oynaBasla()
    {
        int kayitlilevel = PlayerPrefs.GetInt("level");
        if (kayitlilevel == 0)
        {
            SceneManager.LoadScene(kayitlilevel+1);
        }
        else
        {
            SceneManager.LoadScene(kayitlilevel);
        }
    }
    public void cik()
    {
        Application.Quit();
    }

    public void Sifirla()
    {
        PlayerPrefs.DeleteAll();
    }
}
