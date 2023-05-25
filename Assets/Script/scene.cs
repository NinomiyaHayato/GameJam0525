using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scene : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>•Ï‚¦‚½‚¢ƒV[ƒ“‚Ì–¼‘O</summary>
    [SerializeField] string _changeScene;
    public void LoadScenes(string _scene)
    {
        SceneManager.LoadScene(_scene);
    }
}