using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrackingPlayer : MonoBehaviour
{
    public GameObject player; //  player  Camera Will Track him 
    private Vector3 CameraGetAwayFromUser; 
    private void Start()
    {
        CameraGetAwayFromUser = new Vector3(0, 1.5f, -5); //  camera get away  from player 1.5f in Y-axis and -5 in Z-axsis
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = player.transform.position + CameraGetAwayFromUser; //  transfrom camera to new position
    }
}
