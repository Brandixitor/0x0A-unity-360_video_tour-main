using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class CubeController : MonoBehaviour
{
    public GameObject LivingRoom;
    public GameObject Cantina;
    public GameObject Mezzanine;
    public GameObject Cube;
    public GameObject Camera;

    public void livingRoomButton()
    {
        Cube.GetComponent<VideoPlayer>().enabled = false;
        Camera.transform.position = new Vector3(0, 0, 0);
        LivingRoom.GetComponent<VideoPlayer>().enabled = true;
    }

    public void CantinaButton()
    {
        Cube.GetComponent<VideoPlayer>().enabled = false;
        Camera.transform.position = new Vector3(-150, 0, 132);
        Cantina.GetComponent<VideoPlayer>().enabled = true;
    }

    public void MezzanineButton()
    {
        Cube.GetComponent<VideoPlayer>().enabled = false;
        Camera.transform.position = new Vector3(60, 0, 361);
        Mezzanine.GetComponent<VideoPlayer>().enabled = true;
    }
}
