using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kulki : MonoBehaviour
{
    public GameObject[] objekty;

    void Start()
    {
        InvokeRepeating("Losuj", 3f, 3f);
    }
    void Update()
    {
        if(Input.GetButtonDown("Submit"))
        {
            CancelInvoke("Losuj");
        }
        if(Input.GetButtonDown("Jump"))
        {
            Losuj();
        }
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Stworz(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Stworz(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Stworz(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Stworz(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Stworz(4);
        }
    }

    void Losuj()
    {
        GameObject objekt = objekty[Random.Range(0, objekty.Length)];
        Instantiate(objekt, transform.position, Quaternion.identity);
    }

    void Stworz(int i)
    {
        Instantiate(objekty[i], transform.position, Quaternion.identity);
    }
}
