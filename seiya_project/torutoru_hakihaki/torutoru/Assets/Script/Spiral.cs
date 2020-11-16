using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Spiral : MonoBehaviour
{
    public float test;


    void Start()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obj") //moveobjectのrb.massが1になったら子オブジェクトにするようにする
        {
            //Debug.Log("aaaaa");
            //test = other.GetComponent<moveobject>().Getmass();
            //if (test <= 1f)
            //{
                Debug.Log("iiiiiiii");
                //オブジェクトを子要素に
                GameObject emptyObject = new GameObject();
                emptyObject.transform.parent = this.transform;
                other.transform.parent = emptyObject.transform;
                emptyObject.name = "object";
           // }
        }
    }

    //void OnTriggerExit(Collider other)
    //{
    //    other.transform.parent = null;
    //    GameObject emptyObject = GameObject.Find("empty");
    //    Destroy(emptyObject);

    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
