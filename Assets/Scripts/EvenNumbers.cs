using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenNumbers : MonoBehaviour
{
    int count = 100;



    // Start is called before the first frame update
    void Start()
    {
        for (int i = 22; i < count; i = i + 2)
        {
            Debug.Log("Creating count: " + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
