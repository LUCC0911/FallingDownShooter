using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class About : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        
        GameObject master = GameObject.Find("MainScreen");
        GameObject startPanel = master.transform.Find("StartPanel").gameObject;
        GameObject aboutPanel = master.transform.Find("AboutPanel").gameObject;
        
        startPanel.gameObject.SetActive(false);
        aboutPanel.gameObject.SetActive(true);
    }
}
