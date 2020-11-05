using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ueshita : MonoBehaviour
{
    public float nowPosi;
    private moveobject mv;
    
    void Start()
    {
       nowPosi = this.transform.position.y;
       mv = this.gameObject.GetComponent<moveobject>();
    }



    void FixedUpdate()
    {

        if (mv.InArea== true)
        {
            transform.Rotate(new Vector3(10f, -20, 10f));
            transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time / 1, 20.0f), transform.position.z);        }
    }
}