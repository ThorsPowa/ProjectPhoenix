using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NW
{
    [CreateAssetMenu(menuName = "Items/Weapon Item")]
    public class WeaponItem : Item
    {
        public GameObject modelPrefab;
        public bool isUnarmed;

        [Header("Attack Animations")]
        public string Right_Hand_idle;
        public string Left_Hand_idle;


        [Header("Attack Animations")]
        public string OH_Light_Attack_01;
        public string OH_Light_Attack_02;
        public string OH_Light_Attack_03;
        public string OH_Light_Attack_04;
        public string OH_Heavy_Attack_01;
    }
}