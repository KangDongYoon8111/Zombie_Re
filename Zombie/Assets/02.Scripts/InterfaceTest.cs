using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ILogger logger = new ConsoleLogger();
        logger.WriteLog("Hello, World!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
