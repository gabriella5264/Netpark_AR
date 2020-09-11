using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue : MonoBehaviour
{
    public bool blueTrue;

    // Start is called before the first frame update
    void Start()
    {
        blueTrue = false;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onclick()
    {
        blueTrue = true;
    }

    public void Disable()
    {
        blueTrue = false;
    }
}
