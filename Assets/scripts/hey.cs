using UnityEngine;
using UnityEngine.SceneManagement;
public class hey : MonoBehaviour
{
    // Start is called before the first frame update
    public  void Start_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
;    }



}
