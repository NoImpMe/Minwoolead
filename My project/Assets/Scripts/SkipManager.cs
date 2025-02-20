using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SkipManager : MonoBehaviour
{
    public Button gatchaButton;
    private int skipCount;
    public void Skip()
    {
        skipCount = gatchaButton.GetComponent<GatchaManager>().randomInt;
        for (int i = 0; i < skipCount && gatchaButton.interactable; i++)
        {
            gatchaButton.onClick.Invoke();
        }
    }
}
