using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save : MonoBehaviour
{
    static public bool library1;
    static public bool library2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Save();
    }


    public void Save()
    {
        openPopUp.library1 = library1;
        openPopup2.library2 = library2;
    }
}
