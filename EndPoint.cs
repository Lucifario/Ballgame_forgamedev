using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter()
        {
            gameManager.CompleteLevel();
        }
}

