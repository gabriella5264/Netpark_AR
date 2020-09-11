using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoDraw : MonoBehaviour
{
    public bool showLeaf1;
    public bool showLeaf2;

    public int leafNumber;

    void Start()
    {
    }

   

    void Update()
    {

        showLeaf1 = GameObject.Find("leaf1").GetComponent<showLeaf1>().leafDraw1;
        //showLeaf2 = GameObject.Find("leaf2").GetComponent<showLeaf2>().leafDraw2;

        if (showLeaf1 == false && showLeaf2 == false)
        {
            leafNumber = 0;
        }

        if (showLeaf1 == true)
        {
            leafNumber = 1;
        }

        if (showLeaf2 == true)
        {
            leafNumber = 2;
        }
    }

    // Update is called once per frame
    public void GoToDraw()
    {
        if (showLeaf1 == true)
        {
            SceneManager.LoadScene(2);
        }

        if (showLeaf2 == true)
        {
            SceneManager.LoadScene(2);
        }

    }
}
