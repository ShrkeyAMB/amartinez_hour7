using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirthdayScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int C = 0; C < 1; C++)
        {
            Debug.Log(C);
        }
        Debug.Log("This is my birthday month");
        for(int D = 0; D < 27; D++)
        {
            Debug.Log(D);
        }
        Debug.Log("This is my birthday");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
