using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    [SerializeField]
    private GameStateScript gameStateScript;

    [SerializeField]
    private SpriteRenderer correctImage, errorImage;        
    public void ChangeMainGameScene()
    {
        SceneManager.LoadScene("MainGameScene");
    }

    public void AnswerOfCorrect()
    {
        GameManager.Instance.SetCurrentState(GameState.resultTime);
        gameStateScript.ActionSetAnswerArray(1);
        correctImage.gameObject.SetActive(true);
    }

    public void AnswerOfError()
    {
        GameManager.Instance.SetCurrentState(GameState.resultTime);
        gameStateScript.ActionSetAnswerArray(0);
        errorImage.gameObject.SetActive(true);
    }
    
}
