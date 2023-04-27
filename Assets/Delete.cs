using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Delete : MonoBehaviour
{
    public Triangle triangle;

   

    private void OnTriggerStay2D(Collider2D collision)
    {
        triangle = collision.gameObject.GetComponent<Triangle>();

        if (triangle.ismoved == true)
        {
           
            Destroy(collision.gameObject);
        }
    }


}
