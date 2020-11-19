using UnityEngine;

using System.Collections;



public class GameController : MonoBehaviour

{
    public static int count;

    public UnityEngine.UI.Text scoreLabel;

    public void Update()

    {

        count = GameObject.FindGameObjectsWithTag("Obj").Length;

        scoreLabel.text = count.ToString();

    }

}