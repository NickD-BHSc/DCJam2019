
using UnityEngine;

public class TheEnd : MonoBehaviour
{
    public GameManager gameManager;

    //can't get on trigger enter to work properly for some reason
    
    void OnCollisionEnter()
    {
        Debug.Log("Call del");
        gameManager.CompleteLevel();
    }
}
