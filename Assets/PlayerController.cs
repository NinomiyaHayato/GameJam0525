using UnityEngine;
using System.Collections;
public class PlayerController : MonoBehaviour
{
    [Header("ÉvÉåÉCÉÑÅ[ÇÃìÆçÏ")]
    [SerializeField] public float _speed = 0f;
    Rigidbody2D _rb;
    [Header("çUåÇîªíË")]
    [SerializeField] GameObject _attack;
    [SerializeField]
    public float _attactime;
    public float _count;
    float _cooltime = 1.5f;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(x, y).normalized;
        _rb.velocity = dir * _speed;
        if (Input.GetButton("Fire1"))
        {
            StartCoroutine(Attack());
        }
    }
    IEnumerator Attack()
    {
        _attack.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        _attack.SetActive(false);
    }
}
