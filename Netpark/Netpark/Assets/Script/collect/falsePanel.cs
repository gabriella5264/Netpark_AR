using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falsePanel : MonoBehaviour
{
    public GameObject Panel;

    void Update()
    {
        if ((Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) || Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Panel.SetActive(false);
            }
        }
    }
}
