using TMPro;
using UnityEngine;

public class RedStatusSync : MonoBehaviour
{
    public RedWeaponStatus redWeaponStatus;
    public TextMeshProUGUI name;
    public TextMeshProUGUI level;
    public TextMeshProUGUI weaponDamage;
    public TextMeshProUGUI bossDamge;
    public TextMeshProUGUI denyDefence;
    public void Awake()
    {
        name.SetText(redWeaponStatus.name);
        level.SetText(redWeaponStatus.level.ToString());
        weaponDamage.SetText(redWeaponStatus.weaponDamage.ToString());
        bossDamge.SetText(redWeaponStatus.bossDamage.ToString());
        denyDefence.SetText(redWeaponStatus.denyDefence.ToString());
    }
}
