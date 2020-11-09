using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{

    public float speed;
    public float rotatespeed;

    public float PositionX;
    public float PositionY;
    public float PositionZ;

    public GameObject Text;

    // Start is called before the first frame update
    void Start()
    {
        Text.GetComponent<Text>().text = "Position";

        
    }

    // Update is called once per frame
    void Update()
    {

        PositionX = gameObject.transform.position.x;
        PositionY = gameObject.transform.position.y;
        PositionZ = gameObject.transform.position.z;

        //Forward
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(0,0, Time.deltaTime * speed);
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        //Backward
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, 0, Time.deltaTime * speed);
        }

        //Turning Speed Left
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * -rotatespeed, 0));
        }

        //Turning Speed Right
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * rotatespeed, 0));
        }

        //Display Position Co-ordinates
        Text.GetComponent<Text>().text = "Position: (" + PositionX + "," + PositionY + "," + PositionZ + ")";
    }
}
