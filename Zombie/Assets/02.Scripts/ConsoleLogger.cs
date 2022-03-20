using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleLogger : MonoBehaviour, ILogger
{
    public void WriteLog(string message)
    {
        Debug.Log($"{DateTime.Now.ToLocalTime()}, {message}");
    }
}
