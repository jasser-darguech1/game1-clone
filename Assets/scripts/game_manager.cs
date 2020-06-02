using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class game_manager : MonoBehaviour
{
    public NewBehaviourScript mvmnt;
    public GameObject level_complete_ui;
    public float restart_delay = 1f;
    bool game_has_ended = false;

    public void level_finished()
    {
        level_complete_ui.SetActive(true);
        mvmnt.enabled = false;

    }



    public void game_over()
   {
        if (game_has_ended == false)
        {
            game_has_ended = true;
            Invoke("restart", restart_delay);
        }

        
   }
    void restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

  
  

}
