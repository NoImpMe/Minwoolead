using TMPro;
using UnityEngine;

public class BlueStatusSync : MonoBehaviour
{
    public BlueWeaponStatus blueWeaponStatus;
    public TextMeshProUGUI name;
    public TextMeshProUGUI level;
    public TextMeshProUGUI weaponDamage;
    public TextMeshProUGUI bossDamge;
    public TextMeshProUGUI denyDefence;
    public void Awake()
    {
        name.SetText(blueWeaponStatus.name);
        level.SetText(blueWeaponStatus.level.ToString());
        weaponDamage.SetText(blueWeaponStatus.weaponDamage.ToString());
        bossDamge.SetText(blueWeaponStatus.bossDamage.ToString());
        denyDefence.SetText(blueWeaponStatus.denyDefence.ToString());
    }
}
