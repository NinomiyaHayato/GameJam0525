using UnityEngine;

/// <summary>
/// Player�̈ړ����x��ύX����N���X
/// �A�C�e���ɃA�^�b�`���Ďg�p����
/// </summary>
public class PSpeedDownItem : MonoBehaviour
{
    [Header("Player�̈ړ����x�̕ύX�l")]
    [SerializeField] float _downspeed;
    [SerializeField] float _destroytime;
    public float _Pspeed;
    public float _time;

    void Update()
    {
        _time += Time.deltaTime;
        if (_time >= _destroytime)
        {
            _time = 0;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        // �ڐG�����Q�[���I�u�W�F�N�g�̃^�O���hPlayer�h���m�F����
        if (col.gameObject.tag == "Player")
        {
            _Pspeed = GameObject.Find("Player").GetComponent<PlayerController>()._speed;
            _Pspeed -= _downspeed;
        }
    }
}