using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserGenerateButton : MonoBehaviour
{
    [SerializeField]
    GameObject diceStartPositionGO; // 변수는 카멜표기법을 따름

    public void OnButton() {
        Debug.Log("Generate User's Dice start");
        var diceInstanced = GameObject.Instantiate(GameSceneBase.GetActive<BattleScene>().prefabDice); // 다이스를 생성을 했고
        diceInstanced.transform.position = diceStartPositionGO.transform.position;  // 다이스의 transform.position을 dice Start Position 게임오브젝트의 위치를 대입
        Debug.Log("Generate User's Dice end");
    }
}
