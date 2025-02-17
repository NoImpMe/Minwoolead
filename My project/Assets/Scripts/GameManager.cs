using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int count = 0;
    public int gold = 100;
    public int enforceGold = 10;
    BossStatus bossStatus;
    RedWeaponStatus redWeaponStatus;
    BlueWeaponStatus blueWeaponStatus;
    
    void Start()
    {
        bossStatus = gameObject.AddComponent<BossStatus>();
        redWeaponStatus = GameObject.Find("RedWeapon").GetComponent<RedWeaponStatus>();
        redWeaponStatus.initialize(1, 0, 0.3);
        blueWeaponStatus = GameObject.Find("BlueWeapon").GetComponent<BlueWeaponStatus>();
        blueWeaponStatus.initialize(1, 2, 5);
    }
   
    // Update is called once per frame
    //void Update()
    //{
    //    count++;
    //    bossStatus.hit(redweaponStatus.Attack(), redweaponStatus.denyDefence);
    //    if(count == 100)
    //    {
    //        bossStatus.heal();
    //        count = 0;
    //        Debug.Log("현재 체력 : " + Math.Ceiling(bossStatus.hp));
    //    }

    //}
}
