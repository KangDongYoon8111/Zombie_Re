using System;
using UnityEngine;

// ����ü�� ������ ���� ������Ʈ���� ���� ���븦 ����
// ü��, ������ �޾Ƶ��̱�, ��� ���, ��� �̺�Ʈ�� ����
public class LivingEntity : MonoBehaviour, IDamageable
{
    public float startingHealth = 100f; // ���� ü��
    public float health { get; protected set; } // ���� ü��
    public bool dead { get; protected set; } // ��� ����
    public event Action onDeath; // ��� �� �ߵ��� �̺�Ʈ

    /// <summary>
    /// ����ü�� Ȱ��ȭ�� �� ���¸� ����
    /// </summary>
    protected virtual void OnEnable()
    {
        dead = false; // ������� ���� ���·� ����
        health = startingHealth; // ü���� ���� ü������ �ʱ�ȭ

    }

    /// <summary>
    /// ������� �Դ� ���
    /// </summary>
    /// <param name="damage">�������</param>
    /// <param name="hitPoint">Ÿ����ġ</param>
    /// <param name="hitNormal">Ÿ�ݹ���</param>
    public virtual void OnDamage(float damage, Vector3 hitPoint, Vector3 hitNormal)
    {
        health -= damage; // �������ŭ ü�� ����

        if(health <= 0 && !dead) // ü���� 0 ���� �̰ų�(&&) ���� ���� �ʾҴٸ�
        {
            Die(); // ��� ó�� ����
        }
    }

    /// <summary>
    /// ü���� ȸ���ϴ� ���
    /// </summary>
    /// <param name="newHealth">ȸ���� ü�·�</param>
    public virtual void RestoreHealth(float newHealth)
    {
        if (dead) return; // �̹� ����� ��� ü���� ȸ���� �� ����
        health += newHealth; // ü�� �߰�
    }

    /// <summary>
    /// ��� ó��
    /// </summary>
    public virtual void Die()
    {
        if(onDeath != null) // onDeath �̺�Ʈ�� ��ϵ� �޼��尡 �ִٸ�
        {
            onDeath(); // ����
        }

        dead = true; // ��� ���¸� ������ ����
    }
}
