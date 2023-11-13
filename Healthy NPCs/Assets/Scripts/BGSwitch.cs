using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSwitch : MonoBehaviour
{
    public GameObject ground;
    public GameObject evilGround;
    public GameObject text2;
    public GameObject text1;
    public void SwitchProps()
    {
        ground.SetActive(false);
        evilGround.SetActive(true);
        text1.SetActive(false);
        text2.SetActive(true);
    }
}
