using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            
            FindAnyObjectByType<GameManager>().EndGame();

            BackgroundSound.offRun = true;
            BackgroundSound.offEnemy = true;
            BackgroundSound.onDie = true;

            FollowPlayer.following = false;
            PlayerMovement.makeLightweight = true;
            PlayerMovement.makeJump = true;
        }
    }
}
