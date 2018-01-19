using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerControllerNetwork : NetworkBehaviour
{

    private float speed = 7f;
    [SerializeField]
    private GameObject CameraGo;

    void Start()
    {
        name = name + " " + connectionToClient.address.ToString();
        if (!isLocalPlayer)
        {
            CameraGo.SetActive(false);
        }
    }


    void FixedUpdate()
    {
        if (!isLocalPlayer)
            return;
        var x = Input.GetAxis("Horizontal") * speed;
        var y = Input.GetAxis("Vertical") * speed;
        GetComponent<Rigidbody>().AddForce(new Vector3(x,0,y));
    }
}
