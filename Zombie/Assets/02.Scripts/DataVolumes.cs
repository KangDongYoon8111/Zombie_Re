using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataVolumes : MonoBehaviour
{
    void Start()
    {
        VolumeInfo info = new VolumeInfo(); // ���ο� ��ũ �뷮 ���� ����

        info.bytes = 1000000; // bytes�� set ���� > m_byte 1000000�� ��
        Debug.Log(info.kiloBytes); // kiloBytes�� get ���� > 1000 ��µ�
        Debug.Log(info.megaBytes); // megaBytes�� get ���� > 1 ��µ�

        info.megaBytes = 4; // megaBytes�� set ���� > m_byte 4000000�� ��
        Debug.Log(info.bytes); // bytes�� get ���� > 4000000 ��µ�

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
