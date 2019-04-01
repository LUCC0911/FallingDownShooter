using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutClose : MonoBehaviour
{
    public void OnClick()
    {
        GameObject master = GameObject.Find("MainScreen");
        GameObject startPanel = master.transform.Find("StartPanel").gameObject;
        GameObject aboutPanel = master.transform.Find("AboutPanel").gameObject;
        
        startPanel.gameObject.SetActive(true);
        aboutPanel.gameObject.SetActive(false);
    }
}
