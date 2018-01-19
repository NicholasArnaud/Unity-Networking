using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        player = gameObject.GetComponentInParent<GameObject>();
        if (player != null)
            offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                transform.position = player.transform.position + new Vector3(0, 6, -6);
                offset = transform.position - player.transform.position;
            }
                
        }


        else
        {
            transform.position = player.transform.position + offset;
        }

    }
}
