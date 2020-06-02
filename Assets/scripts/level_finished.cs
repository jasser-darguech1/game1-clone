using UnityEngine;
using UnityEngine.SceneManagement;


public class level_finished : MonoBehaviour
{
    public void load_Next_Level()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
