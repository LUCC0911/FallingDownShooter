using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCursor : MonoBehaviour
{
    [SerializeField]
    private Texture2D cursor;
    private Transform CameraTransform;
    public int hit_num=0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursor, new Vector2(cursor.width / 2, cursor.height / 2), CursorMode.ForceSoftware);
        CameraTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        CameraTransform.transform.Rotate(-Y_Rotation, X_Rotation, 0);

        if(Input.GetButtonDown("Fire1")) {
			Shot();
		}
    }

    void Shot() {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
 
		if(Physics.Raycast(ray, out hit, 100f, LayerMask.GetMask("Enemy"))) 
        {
			Destroy(hit.collider.gameObject);
            hit_num++;
		}
	}
}
