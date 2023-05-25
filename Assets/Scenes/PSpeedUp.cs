using UnityEngine;

/// <summary>
/// Player�̈ړ����x��ύX����N���X
/// �A�C�e���ɃA�^�b�`���Ďg�p����
/// </summary>
public class PSpeedUp : MonoBehaviour
{
    [Header("Player�̈ړ����x�̕ύX�l")]
    [SerializeField] float upspeed;
    [SerializeField] float _destroytime;
    float _Pspeed;
    float time;

    void Update()
    {
        time += Time.deltaTime;
        if (time >= _destroytime)
        {
            Destroy(gameObject);
            time = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // �ڐG�����Q�[���I�u�W�F�N�g�̃^�O���hPlayer�h���m�F����
        if (col.gameObject.tag == "Player")
        {
            _Pspeed = GameObject.Find("Player").GetComponent<PlayerController>()._speed;
            _Pspeed += upspeed;
            Destroy(gameObject);
        }
    }
}