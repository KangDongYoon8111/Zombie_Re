using UnityEngine;

public interface IDamageable
{
    // 인터페이스 : 데미지 크기, 공격당한 위치, 공격당한 표면의 방향
    void OnDamage(float damage, Vector3 hitPoint, Vector3 hitNormal);
}