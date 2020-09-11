using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openPopup2 : MonoBehaviour
{
    public GameObject Panel;
    public static openPopup2 Instance;
    public GameObject objects2;
    
    public static bool library2;

    void Start()
    {
        library2 = false;

    }
    


    void Update()
    {

        if ((Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) || Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (gameObject == objects2)
                {
                    //objects2.transform.localScale = new Vector3(0, 0, 0);
                    library2 = true;
                    Panel.SetActive(true);

                    print("library2 is true");
                }
            }
        }


    }
}
