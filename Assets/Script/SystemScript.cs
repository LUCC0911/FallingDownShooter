using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemScript : MonoBehaviour
{

    float x,y,z;
    public GameObject target;
    public int target_num;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Quit();
        }
    }

    public void GenerateTarget()
    {
        for(int i = 0;i < target_num;i++)
        {
            x = Random.Range(-5.0f, 5.0f);
            y = Random.Range(10.0f, 30.0f);
            z = Random.Range(15.0f, 25.0f);

            Instantiate(target, new Vector3(x, y, z), Quaternion.identity);
        }
        
    }

    public void Quit() 
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
        #endif
    }
}
