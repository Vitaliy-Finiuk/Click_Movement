using RPG.AllWeapons;
using RPG.Actions.Weapons;

namespace Weapon.Sword
{
    public class Sword : Weapons, IActionWeapons
    {
        public void Attack()
        {
            _animator.SetTrigger("isAttack");
        }      
    }
}
