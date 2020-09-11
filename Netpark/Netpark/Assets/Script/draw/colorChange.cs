using UnityEngine;

public class colorChange : MonoBehaviour
{
    public Material material;
    public bool red;
    public bool blue;

    int color;

    // Start is called before the first frame update
    void Start()
    {
        material = gameObject.GetComponent<Renderer>().material;
        material.EnableKeyword("_EMISSION");

        red = false;
        blue = false;

        color = 0;
    }

    // Update is called once per frame
    void Update()
    {
        red = GameObject.Find("RedButton").GetComponent<red>().redTrue;
        blue = GameObject.Find("BlueButton").GetComponent<blue>().blueTrue;

        if (red == true)
        {
            color = 1;
        }

        if (blue == true)
        {
            color = 2;
        }


        switch (color)
        {
            case 0:
                material.SetColor("_EmissionColor", Color.black);
                //material.color = Color.black;
                break;
            case 1:
                blue = false;
                material.SetColor("_EmissionColor", Color.red);
                //material.color = Color.red;
                break;

            case 2:
                red = false;
                material.SetColor("_EmissionColor", Color.blue);
                //material.color = Color.blue;
                break;
        }
    }
    
}
