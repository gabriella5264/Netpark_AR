namespace GoogleARCoreExamplesHelloAR
{
    using UnityEngine;


#if UNITY_EDITOR
    using Input = GoogleARCore.InstantPreviewInput;
#endif

    public class paintable : MonoBehaviour
    {
        Plane objPlane;
        //string sceneName;
        GameObject thisTrail;
        public GameObject prefab;
        Vector3 startPos;
        




        // Start is called before the first frame update
        void Start()
        {
            objPlane = new Plane(Camera.main.transform.forward * -1, this.transform.position);

            //sceneName = SceneManager.GetActiveScene().name;

        }

        // Update is called once per frame
        void Update()
        {
                //when the mouse start to click
                if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) || Input.GetMouseButtonDown(0))
            {
                thisTrail = (GameObject)Instantiate(prefab,
                    this.transform.position,
                    Quaternion.identity);

                    Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                    float rayDistance;

                    if (objPlane.Raycast(mRay, out rayDistance))
                    {

                        //startPos = mRay.GetPoint(rayDistance);
                        thisTrail.transform.position = mRay.GetPoint(rayDistance - 1f);


                }


                }

                //when the mouse is clicked
                else if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0))
                {
                    Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                    float rayDistance;

                    if (objPlane.Raycast(mRay, out rayDistance))
                    {
                        thisTrail.transform.position = mRay.GetPoint(rayDistance - 1f);
                    //tr.transform.position = mRay.GetPoint(rayDistance);
                }
                }

                //when the mouse ends to click
                else if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) || Input.GetMouseButtonUp(0))
                {
                    if (Vector3.Distance(thisTrail.transform.position, startPos) < 0.1)
                    {
                        Destroy(thisTrail);
                }
                }
        }

    }
}