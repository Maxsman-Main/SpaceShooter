using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private int nextSceneIndex;

    public void LoadScene()
    {
        SceneManager.LoadScene(nextSceneIndex);
    }
}
