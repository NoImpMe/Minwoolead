using TMPro;
using UnityEngine;

public class EnforceWeaponButton : MonoBehaviour
{
    public RedWeaponStatus redWeaponStatus;
    public GameManager gameManager;
    public TextMeshProUGUI level;

    public void Awake()
    {
        level.SetText(redWeaponStatus.level.ToString());
    }
    //public void Update()
    //{
    //    int gold = gameManager.gold;
    //    int enforceGold = gameManager.enforceGold;
    //}
    public void EnfoceWeapon()
    {
        if (gameManager.gold >= gameManager.enforceGold)
        {
            redWeaponStatus.level += 1;
            level.SetText(redWeaponStatus.level.ToString());
            gameManager.gold = gameManager.gold - gameManager.enforceGold;
            Debug.Log(gameManager.gold);
        }
        else
        {
            Debug.Log("∞ÒµÂ ∫Œ¡∑");
        }
    }
    
}
