using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void OnClick()
    {
        SystemScript sc = GameObject.FindGameObjectWithTag("Player").GetComponent<SystemScript>();
        sc.Quit();
    }
}
