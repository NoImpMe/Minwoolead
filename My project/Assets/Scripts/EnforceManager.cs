using UnityEngine;
using UnityEngine.UI;

public class EnforceManager : MonoBehaviour
{
    public Button enforceWeaponButton;
    public GameManager gameManager;

    public void Awake()
    {
        enforceWeaponButton = GameObject.Find("EnforceWeaponButton").GetComponent<Button>();
    }
    public void Update()
    {
        Debug.Log("강화후 돈: " + gameManager.gold + ", 강화에 사용된 돈: " + gameManager.enforceGold);
        
        if (gameManager.gold >= gameManager.enforceGold)
        {
            enforceWeaponButton.interactable = true;
        }
        else
        {
            enforceWeaponButton.interactable=false;
        }
    }
}
