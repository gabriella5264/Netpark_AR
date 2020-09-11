using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save1 : MonoBehaviour
{
    public static int leafNumber;

    public static save1 Instance1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        if (Instance1 == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance1 = this;
        }
        else if (Instance1 != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        leafNumber = GameObject.Find("Draw").GetComponent<GoDraw>().leafNumber;
    }

}
