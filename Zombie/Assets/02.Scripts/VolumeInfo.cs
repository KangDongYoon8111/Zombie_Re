using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeInfo : MonoBehaviour
{
    public float megaBytes
    {
        get { return m_byte * 0.000001f; }
        set
        {
            if(value <= 0)
            {
                m_byte = 0;
            }
            else
            {
                m_byte = value * 1000000f;
            }
        }
    }

    public float kiloBytes
    {
        get { return m_byte * 0.001f; }
        set
        {
            if(value <= 0)
            {
                m_byte = 0;
            }
            else
            {
                m_byte = value * 1000f;
            }
        }
    }

    public float bytes
    {
        get { return m_byte; }
        set
        {
            if(value <= 0)
            {
                m_byte = 0;
            }
            else
            {
                m_byte = value;
            }
        }
    }

    // 바이트 단위로 용량 기록
    private float m_byte = 0;
}