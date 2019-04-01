using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RePlay : MonoBehaviour
{
    
    private GameObject ground;
    public void OnClick()
    {
        Rigidbody player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        GameObject[] gameObjectArray = SceneManager.GetActiveScene().GetRootGameObjects ();

        foreach (GameObject val in gameObjectArray)
        {
            if(val.name == "StartGround")
            {
                ground = val;
            }
        }

        ground.gameObject.SetActive(true);
        player.position = new Vector3(0,41.6f,0);

    }
}
