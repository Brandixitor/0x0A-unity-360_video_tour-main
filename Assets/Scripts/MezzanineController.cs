using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MezzanineController : MonoBehaviour
{
    public GameObject Mezzanine;
    public GameObject Cube;
    public GameObject Camera;

    public void CubeButton()
    {
        Mezzanine.GetComponent<VideoPlayer>().enabled = false;
        Camera.transform.position = new Vector3(213, 0, 131);
        Cube.GetComponent<VideoPlayer>().enabled = true;
    }
}
