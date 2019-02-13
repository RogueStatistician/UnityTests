using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundPlaneController : MonoBehaviour {


    void OnMouseDown()    {
            Vector3 screenPos = new Vector3(Input.mousePosition.x,Input.mousePosition.y,Input.mousePosition.z);
            var ray = Camera.main.GetComponent<Camera>().ScreenPointToRay(screenPos);
            
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity)){
                if(hit.collider.name ==gameObject.name){
                    Instantiate(HazardManager.instance.GetHazard(),new Vector3(hit.point.x,0.1f,hit.point.z), Quaternion.identity);
                    Debug.Log(ray);
                }
                else{
                    Debug.Log("Plane was clicked but raycast hit something else.");            
                }
            }
            else{        
                Debug.Log("Plane was clicked but raycast missed.");        
            }             
    } 
}

