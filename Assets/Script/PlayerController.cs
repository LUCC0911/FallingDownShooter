using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private SystemScript sc;
    private GameObject cam;
    private ShotCursor shot_sc;
    private Rigidbody rig;
    private Text result_text;
    public float sccore = 0;
    // Start is called before the first frame update
    void Start()
    {
        sc = this.GetComponent<SystemScript>();

        cam = transform.Find("Main Camera").gameObject;
        shot_sc = cam.GetComponent<ShotCursor>();

        rig = this.GetComponent<Rigidbody>();

        result_text = GameObject.FindGameObjectWithTag("ResultText").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        sccore += 1 * Time.deltaTime;

        if(this.transform.position.y < -1)
        {
            rig.position = new Vector3(0,39,0);
            rig.velocity = Vector3.forward * 0.3f;
        }

        if(sc.target_num == shot_sc.hit_num)
        {
            rig.position = new Vector3(0,4.0f,-106);
            shot_sc.hit_num = 0;
            result_text.text = "Time : " + sccore;
        }
    }
}
