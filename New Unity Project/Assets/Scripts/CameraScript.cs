
using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    /* public GameObject background;
     public Transform survivorTransform;

     //Renderers 
     private Renderer renderer_BG, renderer_SV;

     // Height and Widths
     private float w_BG, h_BG, w_CM, h_CM, w_SV, h_SV;

     // Players 3 Dimensional Vector
     private Vector3 v3PlayerPos;

     //Bounds
     private float topBound, bottomBound;
     private float rightBound, leftBound;

     //Detaching variable
     private bool detachInX, detachInY;

   // Use this for initialization
     void Start () {

         //Assign the Survior's renderer to "renderer_SV"
         renderer_SV = survivorTransform.GetComponent<Renderer>();

         // Assign the backgrounds renderer to "renderer_BG"
         renderer_BG = background.GetComponent<Renderer>();

         //Compute the height and width of the background
         w_BG = renderer_BG.bounds.size.x;
         h_BG = renderer_BG.bounds.size.y;

         //Compute the height and of the camera.

         h_BG = Camera.main.orthographicSize * 2.0f;
         w_CM = Camera.main.aspect * h_CM;
         }*/

    // Update is called once per frame
    /*void Update () {
        //Check the Height And Width of Player

        w_SV = renderer_SV.bounds.size.x;
        h_SV = renderer_SV.bounds.size.y;

        //Players 3rd Dimensions vector 
        v3PlayerPos = survivorTransform.position;

        //Computing the bounds
        topBound = h_BG / 2 - h_SV / 2;
        bottomBound = -topBound;
        
        rightBound = w_BG / 2 - w_SV / 2;
        leftBound = -rightBound;

        //Restrain v3Player position the bounds 
        v3PlayerPos.x = Mathf.Clamp(v3PlayerPos.x, leftBound, rightBound);
        v3PlayerPos.y = Mathf.Clamp(v3PlayerPos.y, bottomBound, topBound);
        
        //Set the real players position to v3PlayerPos
        survivorTransform.position = v3PlayerPos;

        // Check for Detaching 
        if (Mathf.Abs(v3PlayerPos.x) + (w_CM / 2) >= (w_BG/2))
        {
            detachInX = true;
        } else {
            detachInX = false;
        }

        if (Mathf.Abs(v3PlayerPos.y) + (h_CM /2) >= (h_BG/2))
        {
            detachInY = true;
        } else {
            detachInY = false; 
        }

        //Make our camera smart
        if (!detachInX && !detachInY)
        {
            Camera.main.transform.position = new Vector3(v3PlayerPos.x, 
                                                         v3PlayerPos.y, 
                                                         Camera.main.transform.position.z);
        } else if (!detachInX && detachInY) {
            Camera.main.transform.position = new Vector3(v3PlayerPos.x,
                                                         Camera.main.transform.position.y, 
                                                         Camera.main.transform.position.z);
        } else if (detachInX && !detachInY)
        {
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x,
                                                         v3PlayerPos.y, 
                                                         Camera.main.transform.position.z);
        } else if (detachInX && detachInY) {
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, 
                                                         Camera.main.transform.position.y, 
                                                         Camera.main.transform.position.z); 
        }
	}*/
    public GameObject background;
    public Transform survivorTransform;

    // Renderers
    private Renderer renderer_BG, renderer_SV;

    // Heights and Widths
    private float w_BG, h_BG, w_CM, h_CM, w_SV, h_SV;

    // Palyer's 3-dimensional vector
    private Vector3 v3PlayerPos;

    // Bounds
    private float topBound, bottomBound;
    private float rightBound, leftBound;

    // Detaching variables
    private bool detachInX, detachInY;


    void Start()
    {

        // Asign the Survivor's renderer to "renderer_SV"
        renderer_SV = survivorTransform.GetComponent<Renderer>();

        // Asign the Background's renderer to "renderer_BG"
        renderer_BG = background.GetComponent<Renderer>();

        // Compute the height and width of the Background
        w_BG = renderer_BG.bounds.size.x;
        h_BG = renderer_BG.bounds.size.y;

        // Compute the height of the Camera
        h_CM = Camera.main.orthographicSize * 2.0f;
        w_CM = Camera.main.aspect * h_CM;

    }

    void Update()
    {

        // Compute the height and width of the Survivor.
        w_SV = renderer_SV.bounds.size.x;
        h_SV = renderer_SV.bounds.size.y;

        // Player's 3-dimensional vector
        v3PlayerPos = survivorTransform.position;

        // Computing the bounds
        topBound = h_BG / 2 - h_SV / 2;
        bottomBound = -topBound;

        rightBound = w_BG / 2 - w_SV / 2;
        leftBound = -rightBound;

        // Restrain v3PlayerPos within the bounds
        v3PlayerPos.x = Mathf.Clamp(v3PlayerPos.x, leftBound, rightBound);
        v3PlayerPos.y = Mathf.Clamp(v3PlayerPos.y, bottomBound, topBound);

        // Set the real player's position to v3PlayerPos
        survivorTransform.position = v3PlayerPos;

        // Check for detaching
        if (Mathf.Abs(v3PlayerPos.x) + (w_CM / 2) >= (w_BG / 2))
        {
            detachInX = true;
        }
        else
        {
            detachInX = false;
        }

        if (Mathf.Abs(v3PlayerPos.y) + (h_CM / 2) >= (h_BG / 2))
        {
            detachInY = true;
        }
        else
        {
            detachInY = false;
        }

        // Make our camera intelligent
        if (!detachInX && !detachInY)
        {
            Camera.main.transform.position = new Vector3(v3PlayerPos.x,
                                                          v3PlayerPos.y,
                                                          Camera.main.transform.position.z);
        }
        else if (!detachInX && detachInY)
        {
            Camera.main.transform.position = new Vector3(v3PlayerPos.x,
                                                          Camera.main.transform.position.y,
                                                          Camera.main.transform.position.z);
        }
        else if (detachInX && !detachInY)
        {
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x,
                                                          v3PlayerPos.y,
                                                          Camera.main.transform.position.z);
        }
        else if (detachInX && detachInY)
        {
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x,
                                                          Camera.main.transform.position.y,
                                                          Camera.main.transform.position.z);
        }
    }
}
