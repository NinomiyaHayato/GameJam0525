using UnityEngine;

/// <summary>
/// Playerの移動速度を変更するクラス
/// アイテムにアタッチして使用する
/// </summary>
public class PSpeedDownItem : MonoBehaviour
{
    [Header("Playerの移動速度の変更値")]
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
        // 接触したゲームオブジェクトのタグが”Player”か確認する
        if (col.gameObject.tag == "Player")
        {
            _Pspeed = GameObject.Find("Player").GetComponent<PlayerController>()._speed;
            _Pspeed -= _downspeed;
        }
    }
}