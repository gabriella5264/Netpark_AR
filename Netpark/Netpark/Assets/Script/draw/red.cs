using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red : MonoBehaviour
{
    public bool redTrue;

    // Start is called before the first frame update
    void Start()
    {
        redTrue = false;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onclick()
    {
        print("red is clicked");
        redTrue = true;
    }

    public void Disable()
    {
        redTrue = false;
    }
}
