using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public static bool following = true;

    public Transform player;
    public Vector3 offset;

    void Start()
    {
        following = true;
    }

    void Update()
    {
        if (following == true)
        {
            follow();
        }
        else
        {
            transform.LookAt(player);
        }
    }
    public void follow()
    {
        transform.position = player.position + offset;
    }
}
