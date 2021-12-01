using UnityEngine;
using RPG.Actions.Weapons;
using Weapon.Sword;

namespace RPG.AllWeapons
{

    public class Weapons : MonoBehaviour
    {
        protected Animator _animator;
        private Sword _sword;

        private void Start()
        {
            _animator = GetComponent<Animator>();
            _sword = GetComponent<Sword>();
        }

        public void Sword()
        {
            _sword.Attack();
        }

        
    }
}
    