using System;
using UnityEngine;

// 생명체로 동작할 게임 오브젝트들을 위한 뼈대를 제공
// 체력, 데미지 받아들이기, 사망 기능, 사망 이벤트를 제공
public class LivingEntity : MonoBehaviour, IDamageable
{
    public float startingHealth = 100f; // 시작 체력
    public float health { get; protected set; } // 현재 체력
    public bool dead { get; protected set; } // 사망 상태
    public event Action onDeath; // 사망 시 발동할 이벤트

    /// <summary>
    /// 생명체가 활성화될 때 상태를 리셋
    /// </summary>
    protected virtual void OnEnable()
    {
        dead = false; // 사망하지 않은 상태로 시작
        health = startingHealth; // 체력을 시작 체력으로 초기화

    }

    /// <summary>
    /// 대미지를 입는 기능
    /// </summary>
    /// <param name="damage">대미지량</param>
    /// <param name="hitPoint">타격위치</param>
    /// <param name="hitNormal">타격방향</param>
    public virtual void OnDamage(float damage, Vector3 hitPoint, Vector3 hitNormal)
    {
        health -= damage; // 대미지만큼 체력 감소

        if(health <= 0 && !dead) // 체력이 0 이하 이거나(&&) 아직 죽지 않았다면
        {
            Die(); // 사망 처리 실행
        }
    }

    /// <summary>
    /// 체력을 회복하는 기능
    /// </summary>
    /// <param name="newHealth">회복할 체력량</param>
    public virtual void RestoreHealth(float newHealth)
    {
        if (dead) return; // 이미 사망한 경우 체력을 회복할 수 없음
        health += newHealth; // 체력 추가
    }

    /// <summary>
    /// 사망 처리
    /// </summary>
    public virtual void Die()
    {
        if(onDeath != null) // onDeath 이벤트에 등록된 메서드가 있다면
        {
            onDeath(); // 실행
        }

        dead = true; // 사망 상태를 참으로 변경
    }
}
