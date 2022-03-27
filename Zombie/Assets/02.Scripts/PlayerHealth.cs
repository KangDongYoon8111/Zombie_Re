using UnityEngine;
using UnityEngine.UI;

// �÷��̾� ĳ������ ����ü�μ��� ������ ���
public class PlayerHealth : LivingEntity
{
    public Slider healthSlider; // ü���� ǥ���� UI �����̴�

    public AudioClip deathClip; // ��� �Ҹ�
    public AudioClip hitClip; // �ǰ� �Ҹ�
    public AudioClip itemPickupClip; // ������ ���� �Ҹ�

    private AudioSource playerAudioPlayer; // �÷��̾� �Ҹ� �����
    private Animator playerAnimator; // �÷��̾��� �ִϸ�����

    private PlayerMovement playerMovement; // �÷��̾� ������ ������Ʈ
    private PlayerShooter playerShooter; // �÷��̾� ���� ������Ʈ

    private void Awake() // ����� ������Ʈ ��������
    {
        // ����� ������Ʈ ��������
        playerAnimator = GetComponent<Animator>();
        playerAudioPlayer = GetComponent<AudioSource>();

        playerMovement = GetComponent<PlayerMovement>();
        playerShooter = GetComponent<PlayerShooter>();
    }

    private void OnEnable()
    {
        // LivingEntity�� OnEnable() ����(���� �ʱ�ȭ)
        base.OnEnable();

        healthSlider.gameObject.SetActive(true); // ü�� �����̴� Ȱ��ȭ
        healthSlider.maxValue = startingHealth; // ü�� �����̴��� �ִ��� �⺻ ü�°����� ����
        healthSlider.value = health; // ü�� �����̴��� ���� ���� ü�°����� ����

        // �÷��̾� ������ �޴� ������Ʈ Ȱ��ȭ
        playerMovement.enabled = true;
        playerShooter.enabled = true;
    }

    public override void RestoreHealth(float newHealth)
    {
        // LivingEntity�� RestoreHealth() ����(ü�� ����)
        base.RestoreHealth(newHealth);

        // ���ŵ� ü������ ü�� �����̴� ����
        healthSlider.value = health;
    }

    public override void OnDamage(float damage, Vector3 hitPoint, Vector3 hitNormal)
    {
        if (!dead) playerAudioPlayer.PlayOneShot(hitClip); // ������� ���� ��쿡�� ȿ���� ���

        // LivingEntity�� OnDamage() ����(����� ����)
        base.OnDamage(damage, hitPoint, hitNormal);

        // ���ŵ� ü���� ü�� �����̴��� �ݿ�
        healthSlider.value = health;
    }

    public override void Die()
    {
        // LivingEntity�� Die() ����(��� ����)
        base.Die();

        // ü�� �����̴� ��Ȱ��ȭ
        healthSlider.gameObject.SetActive(false);

        // ����� ���
        playerAudioPlayer.PlayOneShot(deathClip);
        // �ִϸ������� Die Ʈ���Ÿ� �ߵ����� ��� �ִϸ��̼� ���
        playerAnimator.SetTrigger("Die");

        // �÷��̾� ������ �޴� ������Ʈ ��Ȱ��ȭ
        playerMovement.enabled = false;
        playerShooter.enabled = false;
    }

    private void OnTriggerEnter(Collider other) // �����۰� �浹�� ��� �ش� �������� ����ϴ� ó��
    {
        // �����۰� �浹�� ��� �ش� �������� ����ϴ� ó��
        // ������� ���� ��쿡�� ������ ��� ����
        if (!dead)
        {
            // �浹�� �������κ��� IItem ������Ʈ �������� �õ�
            IItem item = other.GetComponent<IItem>();

            // �浹�� �������κ��� IItem ������Ʈ�� �������µ� �����ߴٸ�
            if(item != null)
            {
                // Use �޼��带 �����Ͽ� ������ ���
                item.Use(gameObject);
                // ������ ���� �Ҹ� ���
                playerAudioPlayer.PlayOneShot(itemPickupClip);
            }
        }
    }
}
