using UnityEngine;

public class end_trigger : MonoBehaviour
{
    public game_manager gameManger;
    private void OnTriggerEnter()
    {
        gameManger.level_finished();
    }
}
