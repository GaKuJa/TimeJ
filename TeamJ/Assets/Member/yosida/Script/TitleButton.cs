using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{
    public void Onclick()
    {
        //�����ňڂ肽���V�[�����w�肵�܂��B
        SceneManager.LoadScene("DifficultyScene");
    }
}
