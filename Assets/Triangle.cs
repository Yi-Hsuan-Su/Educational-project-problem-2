using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Triangle : MonoBehaviour
{
    public GameObject ParentNode;
    public GameObject ClondeNode;
    public  GameObject Traingle_Prefab;
    private Vector3 screenPoint;
    private Vector3 offset;
    private Vector3 Initpos;
   private Transform inittrans;
   public bool ismoved = false;

    private void Start()
    {
        inittrans = transform;
        Initpos = transform.position;

    }

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

    }

    private void OnMouseUp()
    {

        if (transform.position != Initpos && ismoved==false)
        {
            GameObject temp = Instantiate(Traingle_Prefab, Initpos, inittrans.transform.rotation);
            temp.GetComponent<Triangle>().ismoved = false;
            temp.transform.SetParent(ParentNode.transform);
            temp.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            ismoved = true;
             temp.name = this.name;
        }
    }


    private void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.SetParent(ClondeNode.transform);
        transform.position = curPosition;
    }

}

