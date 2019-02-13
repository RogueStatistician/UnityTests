using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float borderWidth = 20f;
	public float cameraSpeed = 20f;
	/*public float zoomSpeed = 200f;
	public int minZoom = 10;
	public int maxZoom = 500;*/
	// Update is called once per frame
	void Update () {
		if(Input.mousePosition.y <= borderWidth){
			transform.Translate(Vector3.back*cameraSpeed*Time.deltaTime,Space.World);
		}
		if(Input.mousePosition.y >= Screen.height-borderWidth){
			transform.Translate(Vector3.forward*cameraSpeed*Time.deltaTime,Space.World);
		}
		if(Input.mousePosition.x <= borderWidth){
			transform.Translate(Vector3.left*cameraSpeed*Time.deltaTime,Space.World);
		}
		if(Input.mousePosition.x >= Screen.width - borderWidth){
			transform.Translate(Vector3.right*cameraSpeed*Time.deltaTime,Space.World);
		}
		
		/* float scroll = Input.GetAxis("Mouse ScrollWheel");

		Vector3 pos = transform.position;

		pos.z -= scroll * 1000 * zoomSpeed * Time.deltaTime;
		pos.z = Mathf.Clamp(pos.z, minZoom, maxZoom);

		transform.position = pos;*/
	}
}
