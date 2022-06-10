using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultDirector : MonoBehaviour
{
    void Update()
    {
        //クリックをするとタイトルにシーンに戻る
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("TitleSceneTest");
            //必ずBuildSettingsでタイトルシーンから先にシーンを登録してください
        }
    }
}
