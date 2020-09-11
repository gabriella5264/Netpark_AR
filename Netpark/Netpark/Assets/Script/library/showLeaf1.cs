using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showLeaf1 : MonoBehaviour
{
    static public bool library1;
    public GameObject Panel;
    public bool leafDraw1;


    // Start is called before the first frame update
    void Start()
    {
        library1 = openPopUp.library1;
        gameObject.GetComponent<UnityEngine.UI.Outline>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (library1 == true)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

        if ((Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) || Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                gameObject.GetComponent<UnityEngine.UI.Outline>().enabled = true;
                leafDraw1 = true;
               
            }
            //else
            //{
            //    gameObject.GetComponent<UnityEngine.UI.Outline>().enabled = false;
            //    leafDraw1 = false;
            //}
        }
    }
    
}
