using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ChangeSoundVolume : MonoBehaviour
{
    AudioSource audioSource;

    private void Start()
    {
        // "AudioSource"コンポーネントを取得
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    /// <summary>
    /// スライドバー値の変更イベント
    /// </summary>
    /// <param name="newSliderValue">スライドバーの値(自動的に引数に値が入る)</param>
    public void SoundSliderOnValueChange(float newSliderValue)
    {
        //オーディオ　.(の)　ボリューム
        // 音楽の音量をスライドバーの値に変更
        audioSource.volume = newSliderValue;
    }

    public void SoundSliderOnPitchChange(float newSliderValue)
    {
            //オーディオ　.(の)　ピッチ
            // 音楽の速度をスライドバーの値に変更
            audioSource.pitch = newSliderValue;
    }
}