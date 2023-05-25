using UnityEngine;

/// <summary>
/// Playerの移動速度を変更するクラス
/// アイテムにアタッチして使用する
/// </summary>
public class PSpeedUp : MonoBehaviour
{
    [Header("Playerの移動速度の変更値")]
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
        // 接触したゲームオブジェクトのタグが”Player”か確認する
        if (col.gameObject.tag == "Player")
        {
            _Pspeed = GameObject.Find("Player").GetComponent<PlayerController>()._speed;
            _Pspeed += upspeed;
            Destroy(gameObject);
        }
    }
}