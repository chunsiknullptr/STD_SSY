using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ϳ��� �����ϴ� ���� ���� ������
public class GameStateManager : Singleton<GameStateManager>
{
    public enum State
    {
        None,
        Ready,
        InBattle,
        End
    }

    public State gameState = State.None;
}
