using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClass : MonoBehaviour
{
    void Start()
    {
        Level level = new Level();
        Debug.Log("HP 1�� Ȯ�� : "+level.hp);
        level.hp = 100;
        Debug.Log("HP 2�� Ȯ�� : " + level.hp);
        
        Debug.Log("Level 1�� Ȯ�� : " + level.GetMyLevel());
        level.SetMyLevel();
        Debug.Log("Level 2�� Ȯ�� : " + level.GetMyLevel());

        Debug.Log("Level2 1�� Ȯ�� : " + level.MyLevel);
        level.MyLevel++;
        Debug.Log("Level2 2�� Ȯ�� : " + level.MyLevel);

        Debug.Log("�ڵ����� ������Ƽ 1�� Ȯ�� : " + level.level);
        //level.level++;
        Debug.Log("�ڵ����� ������Ƽ 2�� Ȯ�� : " + level.level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
