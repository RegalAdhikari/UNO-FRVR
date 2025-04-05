using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{

    public void GotoPlayScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
