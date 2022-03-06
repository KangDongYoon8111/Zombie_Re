using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataVolumes : MonoBehaviour
{
    void Start()
    {
        VolumeInfo info = new VolumeInfo(); // 새로운 디스크 용량 정보 생성

        info.bytes = 1000000; // bytes의 set 실행 > m_byte 1000000이 됨
        Debug.Log(info.kiloBytes); // kiloBytes의 get 실행 > 1000 출력됨
        Debug.Log(info.megaBytes); // megaBytes의 get 실행 > 1 출력됨

        info.megaBytes = 4; // megaBytes의 set 실행 > m_byte 4000000이 됨
        Debug.Log(info.bytes); // bytes의 get 실행 > 4000000 출력됨

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
