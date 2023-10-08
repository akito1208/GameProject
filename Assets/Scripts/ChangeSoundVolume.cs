using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ChangeSoundVolume : MonoBehaviour
{
    AudioSource audioSource;

    private void Start()
    {
        // "AudioSource"�R���|�[�l���g���擾
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    /// <summary>
    /// �X���C�h�o�[�l�̕ύX�C�x���g
    /// </summary>
    /// <param name="newSliderValue">�X���C�h�o�[�̒l(�����I�Ɉ����ɒl������)</param>
    public void SoundSliderOnValueChange(float newSliderValue)
    {
        //�I�[�f�B�I�@.(��)�@�{�����[��
        // ���y�̉��ʂ��X���C�h�o�[�̒l�ɕύX
        audioSource.volume = newSliderValue;
    }

    public void SoundSliderOnPitchChange(float newSliderValue)
    {
            //�I�[�f�B�I�@.(��)�@�s�b�`
            // ���y�̑��x���X���C�h�o�[�̒l�ɕύX
            audioSource.pitch = newSliderValue;
    }
}