using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class oyunKontrol : MonoBehaviour
{
  
    GameObject donenCember;
    GameObject anaCember;
    public Animator animator;
    public Text levelText;
    public Text oksayisi;
    public int oksayac;
    void Start()
    {
        PlayerPrefs.SetInt("level", int.Parse(SceneManager.GetActiveScene().name));
        oksayisibelirt();
        donenCember = GameObject.FindGameObjectWithTag("donenCemberTag");
        anaCember = GameObject.FindGameObjectWithTag("anaCember");
        levelText.text = SceneManager.GetActiveScene().name;

    }

    public void GameOver()
    {
        StartCoroutine(GameOverAniIcinBeklet());
    }
    public void NextLevel()
    {
        int bolumno = int.Parse(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene((bolumno+1).ToString());
    }


    IEnumerator GameOverAniIcinBeklet()
    {
        donenCember.GetComponent<dondurme>().enabled = false;
        anaCember.GetComponent<anaCember>().enabled = false;
        animator.SetTrigger("oyunbitti");

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("Anamenu");


    }

    void oksayisibelirt()
    {
        if (SceneManager.GetActiveScene().name == "1")
        {
            oksayac = 8;
            oksayisi.text = oksayac.ToString();
           
        }
        if (SceneManager.GetActiveScene().name == "2")
        {
            oksayac = 12;
            oksayisi.text = oksayac.ToString();
        }
    }
    public void sayacgoster()
    {
        oksayac--;
        oksayisi.text = oksayac.ToString();
    }
}