using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int level { get; private set; }

    private int myLevel;
    public int hp;

    public int GetMyLevel()
    {
        return myLevel;
    }
    public void SetMyLevel()
    {
        myLevel++;
    }

    private int myLevel2;
    public int MyLevel
    {
        get
        {
            return myLevel2;
        }
        set
        {
            myLevel2 = value;
        }
    }
}
