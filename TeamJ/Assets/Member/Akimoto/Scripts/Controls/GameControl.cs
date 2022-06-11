using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private GameStateScript gameStateScript;
    public Action ActionChangeGameModePlay;
    [SerializeField]
    private UIManager uiManager;

    private void Start()
    {
        ActionChangeGameModePlay = ChangeGameModePlay;
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&
            GameManager.Instance.GetGameState() == GameState.HintTime)
        {
            GameManager.Instance.SetCurrentState(GameState.Playing);
            UIManager.Instance.SetHintMode(HintButtonMode.normal);
        }
        if (Input.GetKeyDown(KeyCode.Space) && 
            SceneManager.GetActiveScene().name == "AnswerScene")
        {
            SceneManager.LoadScene("ResultScene");
        }
    }

    private void ChangeGameModePlay()
    {
        GameManager.Instance.SetCurrentState(GameState.Playing);
    }
    public void ChangeGameModeHint()
    {
        GameManager.Instance.SetCurrentState(GameState.HintTime);
    }

    public void ChangeGameModeAnswer()
    {
        GameManager.Instance.SetCurrentState(GameState.AnswerTime);
    }
    private void ChangeScenen()
    {
        if (gameStateScript.FuncGetQuetionNum() < 4)
            SceneManager.LoadScene("MainGameScene");
    }
}
