using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class omosa : MonoBehaviour
{
    //最大容量と現在の容量。
    int MaxCapacity = 150;
    public static int currentCap;
    int damage;
    //Sliderを入れる
    public Slider slider;
    public Image sliderImage;

    void Start()
    {
        //Sliderを空にする。
        slider.value = 0;
        Debug.Log("Start currentCap : " + currentCap);
    }

    //ColliderオブジェクトのIsTriggerにチェック入れること。
    private void OnTriggerEnter(Collider collider)
    {
        //Enemyタグのオブジェクトに触れると発動
        if (collider.gameObject.tag == "Obj")
        {
            //ダメージは1～100の中でランダムに決める。
            damage = 2;
            Debug.Log("damage : " + damage);

            //現在のHPからダメージを引く
            currentCap = currentCap + damage;
            Debug.Log("After currentHp : " + currentCap);

            //最大HPにおける現在のHPをSliderに反映。
            //int同士の割り算は小数点以下は0になるので、
            //(float)をつけてfloatの変数として振舞わせる。
            slider.value = (float)currentCap / (float)MaxCapacity; ;
            Debug.Log("slider.value : " + slider.value);
        }

        if (collider.gameObject.tag == "Obj_chu")
        {
            //ダメージは1～100の中でランダムに決める。
            damage = 8;
            Debug.Log("damage : " + damage);

            //現在のHPからダメージを引く
            currentCap = currentCap + damage;
            Debug.Log("After currentHp : " + currentCap);

            //最大HPにおける現在のHPをSliderに反映。
            //int同士の割り算は小数点以下は0になるので、
            //(float)をつけてfloatの変数として振舞わせる。
            slider.value = (float)currentCap / (float)MaxCapacity; ;
            Debug.Log("slider.value : " + slider.value);
        }

        if (collider.gameObject.tag == "Obj_dai")
        {
            //ダメージは1～100の中でランダムに決める。
            damage = 12;
            Debug.Log("damage : " + damage);

            //現在のHPからダメージを引く
            currentCap = currentCap + damage;
            Debug.Log("After currentHp : " + currentCap);

            //最大HPにおける現在のHPをSliderに反映。
            //int同士の割り算は小数点以下は0になるので、
            //(float)をつけてfloatの変数として振舞わせる。
            slider.value = (float)currentCap / (float)MaxCapacity; ;
            Debug.Log("slider.value : " + slider.value);
        }
    }

    void Update()
    {
        if (omosa.currentCap >= 60)
        {
            sliderImage.color = new Color32(240, 165, 0, 255);
        }

        if (omosa.currentCap >= 125)
        {
            sliderImage.color = new Color32(255, 80, 0, 255);
        }

        if (omosa.currentCap >= 150)
        {
            sliderImage.color = new Color32(255, 0, 0, 255);
        }
    }
}