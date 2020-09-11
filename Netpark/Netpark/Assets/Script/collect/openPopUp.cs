using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openPopUp : MonoBehaviour
{
    public GameObject Panel;
    public static openPopUp Instance;
    public GameObject objects1;
    
    public static bool library1;

    void Start()
    {
        library1 = false;

    }
    

    void Update()
    {

        if ((Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) || Input.GetMouseButtonDown(0))
        {            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {
                if (gameObject == objects1)
                {
                    objects1.transform.localScale = new Vector3(0, 0, 0);
                    library1 = true;
                    Panel.SetActive(true);

                    print("library1 is true");
                }
            }
        }

        
    }
}
