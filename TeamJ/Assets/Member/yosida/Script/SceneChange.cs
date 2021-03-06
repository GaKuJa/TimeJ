using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    GameObject ManageObject;
    SceneFadeManager fadeManager;
    // Start is called before the first frame update
    void Start()
    {
        //SceneFadeManagerがアタッチされているオブジェクトを取得
        ManageObject = GameObject.Find("Panel");
        //オブジェクトの中のSceneFadeManagerを取得
        fadeManager = ManageObject.GetComponent<SceneFadeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //SceneFadeManagerの中のフェードアウト開始関数を呼び出し
            fadeManager.fadeOutStart(0, 0, 0, 0, "Stage1");
        }
    }
}
