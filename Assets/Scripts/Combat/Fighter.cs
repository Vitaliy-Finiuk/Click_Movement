using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        [SerializeField] private float _MeleeWeaponRange = 2f;
        [SerializeField] private LayerMask _enemyLayer;
        [SerializeField] private Transform _target;
        [SerializeField] float _weaponDamage = 6f;

        public void TakeDamage()
        {
            Collider[] hitEnemys = Physics.OverlapSphere(_target.position, _MeleeWeaponRange, _enemyLayer);

            foreach (Collider enemy in hitEnemys)
            {
                enemy.GetComponent<Health>().ApplyDamage(_weaponDamage);

                Debug.Log("wem het" + enemy.name);

            }
        }
    }
}

