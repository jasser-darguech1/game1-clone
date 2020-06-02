
using UnityEngine;

public class playercollison : MonoBehaviour
{
    public NewBehaviourScript mvmnt;


    private void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {

            mvmnt.enabled = false;
            FindObjectOfType<game_manager>().game_over();
        }
    }

}