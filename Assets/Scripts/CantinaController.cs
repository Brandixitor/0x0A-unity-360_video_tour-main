using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class CantinaController : MonoBehaviour
{
    public GameObject LivingRoom;
    public GameObject Cantina;
    public GameObject Cube;
    public GameObject Camera;

    public void LivingRoomButton()
    {
        Cantina.GetComponent<VideoPlayer>().enabled = false;
        Camera.transform.position = new Vector3(0, 0, 0);
        LivingRoom.GetComponent<VideoPlayer>().enabled = true;
    }

    public void CubeButton()
    {
        Cantina.GetComponent<VideoPlayer>().enabled = false;
        Camera.transform.position = new Vector3(213, 0, 131);
        Cube.GetComponent<VideoPlayer>().enabled = true;
    }
}
