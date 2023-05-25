using UnityEngine;

/// <summary>
/// Player�̈ړ����x��ύX����N���X
/// �A�C�e���ɃA�^�b�`���Ďg�p����
/// </summary>
public class PSpeedUpItem : MonoBehaviour
{
    [Header("Player�̈ړ����x�̕ύX�l")]
    [SerializeField] float upspeed;
    public float _Pspeed;
    public float time;

    void Update()
    {
        time += Time.deltaTime;
        if (time >= 10)
        {
            time = 0;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // �ڐG�����Q�[���I�u�W�F�N�g�̃^�O���hPlayer�h���m�F����
        if (col.gameObject.tag == "Player")
        {
            _Pspeed = GameObject.Find("Player").GetComponent<PlayerController>().speed;
            _Pspeed += upspeed;
        }
    }
}