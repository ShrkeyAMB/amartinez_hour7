using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 0;
        do
        {
            count = count + 1;
            Debug.Log("This is my count" + count);

        }
        while (count > 0);

        count = 9;

        while (count > 0)
        {
            count = count - 1;
            Debug.Log("this is my count" + count);
        }
        for(int i = 10; i>0;i--)
        {
            Debug.Log("This is my count" + count);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
