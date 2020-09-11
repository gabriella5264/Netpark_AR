using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showLeaf2 : MonoBehaviour
{
    static public bool library2;


    // Start is called before the first frame update
    void Start()
    {
        library2 = openPopup2.library2;
    }

    // Update is called once per frame
    void Update()
    {

        if (library2 == true)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
