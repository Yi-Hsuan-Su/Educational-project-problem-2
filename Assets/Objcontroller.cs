using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objcontroller : MonoBehaviour
{
    public GameObject parentnode;

    public void Clean()
    { 
        foreach (Transform child in parentnode.transform)
        {
            
              Debug.Log("hihihi");
            GameObject.Destroy(child.gameObject);
        }
    }
}
