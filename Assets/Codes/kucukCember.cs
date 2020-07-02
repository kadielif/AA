using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukCember : MonoBehaviour
{
    public float hiz;
    Rigidbody2D fizik;
    bool hareketKontrol = false;
    public GameObject oyunKontrol;


    void Start()
    {

        fizik = GetComponent<Rigidbody2D>();
        oyunKontrol = GameObject.FindGameObjectWithTag("oyunKontrol");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!hareketKontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
            //yukarı gitmesi için vector.up
        }
    }

    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="donenCemberTag")
        {
            transform.SetParent(col.transform);
            hareketKontrol = true;
            oyunKontrol.GetComponent<oyunKontrol>().sayacgoster();
            if (oyunKontrol.GetComponent<oyunKontrol>().oksayac == 0)
            {
                oyunKontrol.GetComponent<oyunKontrol>().NextLevel();
            }


        }
        if (col.tag=="kucukCember")
        {
            oyunKontrol.GetComponent<oyunKontrol>().GameOver();
        }
    }
}
