using UnityEngine;

// 좀비 생성시 사용할 셋업 데이터
[CreateAssetMenu(menuName = "Scriptable/ZombieData", fileName = "Zombie Data")]
public class ZombieData : ScriptableObject
{
    /// <summary>
    /// 체력
    /// </summary>
    public float newHealth = 100f;
    /// <summary>
    /// 공격력
    /// </summary>
    public float newDamage = 20f;
    /// <summary>
    /// 이동 속도
    /// </summary>
    public float speed = 2f;
    /// <summary>
    /// 피부색
    /// </summary>
    public Color skinColor = Color.white;
}
