using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobject : MonoBehaviour
{
    //スタートと終わりの目印
    public Transform startMarker;
    public Transform endMarker;

    // スピード
    public float speed = 1.0F;

    //二点間の距離を入れる
    private float distance_two;


    //フラグ用
    public  bool InArea;

    private Rigidbody rb;
    //public float thrust = 1.0f;

    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {

        if (endMarker != null)      //終点が入って無ければ動かない
        {

            // 現在の位置
            float present_Location = (Time.time * speed) / distance_two;
             if (present_Location < 0.6f)
            {
                // オブジェクトの移動
                transform.position = Vector3.Lerp(startMarker.position, endMarker.position, present_Location);
            }

        }

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "test")
        {
            rb.mass -= 1;
            if(rb.mass < 1)
            {
                rb.useGravity = false; // これをオフにしたら浮くようになる

                InArea = true; //これをオンにしないと上にあげる処理に飛ばない
                rb.mass = 1;　 //重さを1にしてmassが0にならないようにしている
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "test" && rb.mass <= 1)
        {
            //竜巻の範囲内に入ったら終点を自動的に入れる
            endMarker = other.gameObject.GetComponent<Transform>();

            //二点間の距離を代入(スピード調整に使う)
            distance_two = Vector3.Distance(startMarker.position, endMarker.position);

            //rb.useGravity = false; // これをオフにしたら浮くようになる

            //InArea = true;
        }

        if(other.gameObject.tag == "Player" && rb.mass <= 1)
        {
            GetComponent<MeshCollider>().enabled = false;
            this.enabled = false;
        }
    }


    void OnTriggerExit(Collider other)
    {
         if(other.gameObject.tag == "test")
        {
            endMarker = null;
            this.enabled = true;
            InArea = false;
        }
    }

    public float Getmass()
    {
        return GetComponent<Rigidbody>().mass; //どこに？あーおｋ
    }
}
