using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAShootBullet : MonoBehaviour
{
    public NormalBullet bulletPrefab;

    [SerializeField]
    HowTarget howTarget = HowTarget.Fornt;

    const float coolTime = 1f;
    float accTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        accTime += Time.deltaTime;
        if(accTime >= 1f)
        {
            // 1�ʰ� ����,
            accTime = 0;

            var targetMonster = MonsterManager.Instance.GetTarget(howTarget);
            if (targetMonster == null)
                return;

            var bullet = GameObject.Instantiate(bulletPrefab);
            bullet.transform.position = transform.position;
            bullet.SetTarget(targetMonster.transform);
        }

        // 1. ������ġ (o)
        // 2. ����     (o) 
        // 3. �ʹ����� ��(o)
        // 4. MonsterManager, ���͸� �߰��� ���س���.(o)
    }
}
