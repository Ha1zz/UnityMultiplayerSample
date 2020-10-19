using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class CubeController : MonoBehaviour
{

    public string cubeid = "";
    public float speed = 4;
    NetworkClient network;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("HERE NOW");
        network = GameObject.Find("NetworkManClient").GetComponent<NetworkClient>();
    }

    // Update is called once per frame
    void Update()
    {
        cubeid = network.myID;
        if (gameObject.name == network.myID)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(-Vector3.forward * Time.deltaTime * speed);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(-Vector3.left * Time.deltaTime * speed);
            }
        }
    }
}
