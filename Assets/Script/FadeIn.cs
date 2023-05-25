using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FadeIn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Image img; // �����ȍ����摜
    [SerializeField] float timer = 3f;
    float time;
    [SerializeField] float fadetime = 0.02f;
    [SerializeField] string _sceneName;
     AudioSource _audio;
    [SerializeField] AudioClip _clip;
    //StartCoroutine("FadeIn"); // �t�F�[�h�C�����J�n
    public void ClickBotton()
    {
        StartCoroutine("Age");
    }
    private void Start()
    {
        _audio = GameObject.Find("AudioSource").GetComponent<AudioSource>();
    }
    IEnumerator Age()
    {
        img.gameObject.SetActive(true); // �摜���A�N�e�B�u�ɂ���
        Color c = img.color;
        c.a = 0f;
        img.color = c; // �摜�̕s�����x��1�ɂ���
        while (time < timer)
        {
            time += Time.deltaTime;
            float a = time / timer;
            c.a += fadetime;
            img.color = c; // �摜�̕s�����x���グ��
            yield return null;
            if (c.a >= 255f) // �s�����x��0�ȉ��̂Ƃ�
            {
                break; // �J��Ԃ��I��
            }
        }
        SceneManager.LoadScene(_sceneName);
    }
    public void Audio()
    {
        _audio.PlayOneShot(_clip);
    }
}