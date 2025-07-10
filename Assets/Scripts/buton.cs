using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buton : MonoBehaviour
{
    public GameObject usa;
    private bool ok = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        usa.SetActive(ok);
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Juc"))
        {
            Debug.Log("Player triggered a PowerUp!");
            ok = false;
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Juc"))
        {
            Debug.Log("Player triggered a PowerUp!");
            ok = true;
        }
    }
}
