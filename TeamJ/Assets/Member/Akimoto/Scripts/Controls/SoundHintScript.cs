using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SoundHintScript : MonoBehaviour
{
    [FormerlySerializedAs("soundManager")]
    [FormerlySerializedAs("soundManagers")]
    [SerializeField]
    private SoundManager soundManager;

    [SerializeField]
    private AudioClip clipData1;

    public void SoundHint()
    {
        Debug.Log("Sound!");
        soundManager.PlaySE(clipData1);
    }
}
