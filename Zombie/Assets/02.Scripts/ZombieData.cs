using UnityEngine;

// ���� ������ ����� �¾� ������
[CreateAssetMenu(menuName = "Scriptable/ZombieData", fileName = "Zombie Data")]
public class ZombieData : ScriptableObject
{
    /// <summary>
    /// ü��
    /// </summary>
    public float newHealth = 100f;
    /// <summary>
    /// ���ݷ�
    /// </summary>
    public float newDamage = 20f;
    /// <summary>
    /// �̵� �ӵ�
    /// </summary>
    public float speed = 2f;
    /// <summary>
    /// �Ǻλ�
    /// </summary>
    public Color skinColor = Color.white;
}
