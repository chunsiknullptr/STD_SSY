using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserGenerateButton : MonoBehaviour
{
    [SerializeField]
    GameObject diceStartPositionGO; // ������ ī��ǥ����� ����

    [SerializeField]
    GameObject diceNextPositionGO; 

    public void OnButton() {
        Debug.Log("Generate User's Dice start");
        var diceInstanced = GameObject.Instantiate(GameSceneBase.GetActive<BattleScene>().prefabDice); // ���̽��� ������ �߰�
        diceInstanced.transform.position = diceStartPositionGO.transform.position;  // ���̽��� transform.position�� dice Start Position ���ӿ�����Ʈ�� ��ġ�� ����

        var diffToDir = diceNextPositionGO.transform.position - diceStartPositionGO.transform.position; // ������ �Ʒ��� ���ϴ� ���� ����

        // �������� 5��
        // ���ο��� 3��
        var randIndexX = Random.Range(0, 5);
        var randIndexY = Random.Range(0, 3);

        var rangeFromStartX = diffToDir.x * randIndexX;
        var rangeFromStartY = diffToDir.y * randIndexY;

        // ������� ó�� �ֻ����� ��ġ�� ������ �ε�����ŭ �̵���
        diceInstanced.transform.position += new Vector3(rangeFromStartX, rangeFromStartY);

        Debug.Log("Generate User's Dice end");
    }
}
