using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickOutsidebehaviour : MonoBehaviour
{
    public GameObject plane;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {

            if(Input.touchCount ==1)
            {
                //if we click on ui element , out
                if(EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    return;
                }
                else
                {
                    Vector3 randomPos = new Vector3(Random.Range(plane.transform.position.x - plane.transform.lossyScale.x/2, plane.transform.position.x + plane.transform.lossyScale.x / 2), plane.transform.position.y + 0.5f, Random.Range(plane.transform.position.z - plane.transform.lossyScale.z / 2, plane.transform.position.z + plane.transform.lossyScale.z / 2));
                    GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = randomPos;
                }
            }
        }
    }
}
