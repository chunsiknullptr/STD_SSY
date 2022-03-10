using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserGenerateButton : MonoBehaviour
{
    [SerializeField]
    GameObject diceStartPositionGO; // ������ ī��ǥ����� ����

    public void OnButton() {
        Debug.Log("Generate User's Dice start");
        var diceInstanced = GameObject.Instantiate(GameSceneBase.GetActive<BattleScene>().prefabDice); // ���̽��� ������ �߰�
        diceInstanced.transform.position = diceStartPositionGO.transform.position;  // ���̽��� transform.position�� dice Start Position ���ӿ�����Ʈ�� ��ġ�� ����
        Debug.Log("Generate User's Dice end");
    }
}
