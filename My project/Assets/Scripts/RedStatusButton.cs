using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public bool redIsVisible = false;
    public GameObject redStatus;

    public void ShowRedStatus()
    {
        if (!redIsVisible)
        {
            redStatus.SetActive(true);
            redIsVisible = true;
        }
        else
        {
            redStatus.SetActive(false);
            redIsVisible = false;
        }
    }
    
}
