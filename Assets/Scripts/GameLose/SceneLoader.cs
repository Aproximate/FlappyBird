using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Load(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void LoadOpenScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}