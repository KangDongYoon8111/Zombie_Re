using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyClass : MonoBehaviour
{
    void Start()
    {
        Level level = new Level();
        Debug.Log("HP 1차 확인 : "+level.hp);
        level.hp = 100;
        Debug.Log("HP 2차 확인 : " + level.hp);
        
        Debug.Log("Level 1차 확인 : " + level.GetMyLevel());
        level.SetMyLevel();
        Debug.Log("Level 2차 확인 : " + level.GetMyLevel());

        Debug.Log("Level2 1차 확인 : " + level.MyLevel);
        level.MyLevel++;
        Debug.Log("Level2 2차 확인 : " + level.MyLevel);

        Debug.Log("자동구현 프로퍼티 1차 확인 : " + level.level);
        //level.level++;
        Debug.Log("자동구현 프로퍼티 2차 확인 : " + level.level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
