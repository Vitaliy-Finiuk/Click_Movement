using UnityEngine;
using RPG.AllWeapons;
using RPG.Combat;

[RequireComponent(typeof(PlayerMover), typeof(Weapons), typeof(Fighter))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMover _playerMover;
    private Weapons _weapons;
    private Fighter _fighter;

    private void Start()
    {
        _playerMover = GetComponent<PlayerMover>();
        _weapons = GetComponent<Weapons>();
        _fighter = GetComponent<Fighter>();
    }
    private void Update()
    {
        Movement();
        Attack();
    }

    private void Movement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _playerMover.MoveToCursor();
        }
    }

    private void Attack()
    {

        if (Input.GetKeyDown("e"))
        {
            _weapons.Sword();
            _fighter.TakeDamage();
        }
    }
}
