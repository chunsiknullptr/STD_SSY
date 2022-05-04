using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum HowTarget
{
    Fornt,
    Random,
    Back,
}

// Ŀ�ø��� �����Ұ��ΰ�, ĸ��ȭ�� ���������� �켱�� �� ���ΰ�.
// Monster�� �������� ����. �ܼ� ����, �׸��� Ÿ�ٰ����� ���Ϳ� ���� �����͸� �����ϰ� ������ ��������� �����.
public class MonsterManager : Singleton<MonsterManager>
{
    // ���� ��ü�� Ÿ���ÿ� ���� ���� �� ����.
    // ���� �ڷᱸ���� ���� ����
    // �ֽ�ȭ�ǰ� Ÿ�ٰ����� ���͵鸸 ����ֽ��ϴ�.
    List<Monster> monsters = new List<Monster>(); 

    public void AddTargetable(Monster monster)
    {
        monsters.Add(monster);
    }

    public void RemoveTarget(Monster monster)
    {
        monsters.Remove(monster);
    }

    public Monster GetTarget(HowTarget how)
    {
        if (monsters.Count <= 0)
            return null;

        switch (how)
        {
            case HowTarget.Fornt:
                return monsters[0];
            case HowTarget.Random:
                break;
            case HowTarget.Back:
                break;
        }
        return null;
    }
}
