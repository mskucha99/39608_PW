using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kulka : MonoBehaviour
{
    public float speed;
    public GameObject kuleczka;
    public Material[] kolory;

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(x, y, 0);

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pozycja = Input.mousePosition;
            pozycja.z = 15f;
            pozycja = Camera.main.ScreenToWorldPoint(pozycja);
            LosujKolor();
            Instantiate(kuleczka, pozycja, Quaternion.identity);
        }
    }
    
    void LosujKolor()
    {
        int rand = Random.Range(0, kolory.Length);
        kuleczka.transform.GetComponent<Renderer>().material = kolory[rand];
    }
}
