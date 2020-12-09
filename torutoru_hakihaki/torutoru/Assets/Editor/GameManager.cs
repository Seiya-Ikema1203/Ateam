using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour
{
    #if UNITY_EDITOR
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) END();
    }

    public void Title_Stage1()
    {
        EditorSceneManager.LoadScene("STAGE 1");
    }

    public void END()
    {
        
        UnityEditor.EditorApplication.isPlaying = false;
        
    }

#endif
}
