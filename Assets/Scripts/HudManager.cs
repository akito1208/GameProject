using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class HudManager : MonoBehaviour
{
    [SerializeField]
    TMP_Dropdown dropdown;
    [SerializeField]
    PlayerInputManager PlayerInputManager;
    [SerializeField]
    private GameObject player;

    public void AddButton()
    {
        Invoke("JoinPlayer",0f);
    }
    private void JoinPlayer()
    {
        //�ǂ����炩��������Ă���
        for(int i = 0; i < dropdown.value+1; i++)
        {
            PlayerInputManager.instance.JoinPlayer(i, -1, null);
            Instantiate(player, new Vector3(-1.0f, 0.0f, 0.0f), Quaternion.identity);
        }
    }
}