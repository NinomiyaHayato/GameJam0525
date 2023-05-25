using UnityEngine;
using System.Collections;
public class PlayerController : MonoBehaviour
{
    [Header("ÉvÉåÉCÉÑÅ[ÇÃìÆçÏ")]
    [SerializeField] public float _speed = 0f;
    Rigidbody2D _rb;
    [Header("çUåÇîªíË")]
    [SerializeField] GameObject _attack;
    AudioSource _audio;
    [SerializeField] AudioClip _clip;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _audio = GetComponent<AudioSource>();
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
        _audio.PlayOneShot(_clip);
        yield return new WaitForSeconds(0.3f);
        _attack.SetActive(false);
    }
}
