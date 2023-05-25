using UnityEngine;

/// <summary>
/// Playerの移動速度を変更するクラス
/// アイテムにアタッチして使用する
/// </summary>
public class PSpeedUpItem : MonoBehaviour
{
    [Header("Playerの移動速度の変更値")]
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
        // 接触したゲームオブジェクトのタグが”Player”か確認する
        if (col.gameObject.tag == "Player")
        {
            _Pspeed = GameObject.Find("Player").GetComponent<PlayerController>().speed;
            _Pspeed += upspeed;
        }
    }
}