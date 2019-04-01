using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{

    public void OnClick()
    {
        
        GameObject obj = GameObject.FindGameObjectWithTag("Ground");

        GameObject pl = GameObject.Find("Player");
        SystemScript sc = pl.GetComponent<SystemScript>();
        sc.GenerateTarget();

        PlayerController plc = pl.GetComponent<PlayerController>();
        plc.sccore = 0;

        obj.gameObject.SetActive(false);
    }

    
}
