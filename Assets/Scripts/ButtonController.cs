using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ButtonController : MonoBehaviour
{
    public GameObject LivingRoom;
    public GameObject Cantina;
    public GameObject Cube;
    public GameObject Camera;

    public void CantinaButton()
    {
        LivingRoom.GetComponent<VideoPlayer>().enabled = false;
        Camera.transform.position = new Vector3(-150, 0, 130);
        Cantina.GetComponent<VideoPlayer>().enabled = true;
    }

    public void CubeButton()
    {
        LivingRoom.GetComponent<VideoPlayer>().enabled = false;
        Camera.transform.position = new Vector3(183, 0, 130);
        Cube.GetComponent<VideoPlayer>().enabled = true;
    }
}
