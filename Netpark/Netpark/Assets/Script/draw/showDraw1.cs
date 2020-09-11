using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showDraw1 : MonoBehaviour
{
    public static int leaf1;

    // Start is called before the first frame update
    void Start()
    {
        leaf1 = save1.leafNumber;
    }

    // Update is called once per frame
    void Update()
    {
        if (leaf1 == 1)
        {
            gameObject.transform.localScale = new Vector3(3f, 3f, 3f);
        }

        else
        {
            gameObject.transform.localScale = new Vector3(0, 0, 0);
        }

    }
}
