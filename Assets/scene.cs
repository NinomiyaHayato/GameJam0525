using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scene : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>�ς������V�[���̖��O</summary>
    [SerializeField] string _changeScene;
    public void LoadScenes()
    {
        SceneManager.LoadScene(_changeScene);
    }
}