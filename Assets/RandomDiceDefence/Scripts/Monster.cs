using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    MonsterPathes monsterPathes;
    int currentPathIndex = 0;

    private void Start()
    {
        // caching 임시객체를 저장해서 변수로 갖고있자
        monsterPathes = GameSceneBase.GetActive<BattleScene>().GetMonsterPathes;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPathIndex >= monsterPathes.GetPathes.Count)
        {
            currentPathIndex = 0;
            return;
        }

        var currentPath = monsterPathes.GetPathes[currentPathIndex].transform.position;
        var currentPos = transform.position;
        
        // 방향 백터
        // 좌표계 
        var dirVec = currentPath - currentPos;
        transform.position += dirVec.normalized * Time.deltaTime * 4f;

        // 도착했는지 체크 후 목적지 다음으로 바꿈
        if(dirVec.magnitude < 0.5f)
        {
            currentPathIndex++;
        }
    }
}
