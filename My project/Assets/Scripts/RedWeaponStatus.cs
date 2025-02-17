using Unity.VisualScripting;
using UnityEngine;

public class RedWeaponStatus : MonoBehaviour
{
    public new string name = "redweapon";
    public int level = 1;
    public double weaponDamage = 1;
    public double bossDamage = 0;
    public double denyDefence = 0;
    

    public double Attack()
    {
        double damage = 0;
        damage = weaponDamage * (1 + bossDamage);
        return damage;
    }
    public void initialize(int level, int bossDamage, double denyDefence)
    {
        this.level = level;
        weaponDamage = level * 3;
        this.bossDamage = bossDamage;
        this.denyDefence = denyDefence;
    }

}
