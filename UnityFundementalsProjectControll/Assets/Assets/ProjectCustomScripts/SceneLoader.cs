using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadScene(int pSceneIndex)
    {
        SceneManager.LoadScene(1);
    }

    public void LoadScene(string pSceneName)
    {
        SceneManager.LoadScene(pSceneName);
    }
}
