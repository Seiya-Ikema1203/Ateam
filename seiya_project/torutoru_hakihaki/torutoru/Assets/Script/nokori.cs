using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nokori : MonoBehaviour
{
	public UnityEngine.UI.Text scorelabel;
	//public GameObject winnerLabelObject;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		int count = GameObject.FindGameObjectsWithTag("Obj").Length;
		scorelabel.text = count.ToString();

		if (count == 0)
		{
			//クリアの処理
			Debug.Log("aa");
		}
	}
}
