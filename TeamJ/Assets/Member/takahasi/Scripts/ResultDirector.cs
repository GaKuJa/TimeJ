using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultDirector : MonoBehaviour
{
    void Update()
    {
        //�N���b�N������ƃ^�C�g���ɃV�[���ɖ߂�
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("TitleSceneTest");
            //�K��BuildSettings�Ń^�C�g���V�[�������ɃV�[����o�^���Ă�������
        }
    }
}
