using UnityEngine;

public class BlueStatusButton : MonoBehaviour
{
    public bool blueIsVisible = false;
    public GameObject blueStatus;

    public void ShowBlueStatus()
    {
        if (!blueIsVisible)
        {
            blueStatus.SetActive(true);
            blueIsVisible = true;
        }
        else
        {
            blueStatus.SetActive(false);
            blueIsVisible = false;
        }
    }
}
