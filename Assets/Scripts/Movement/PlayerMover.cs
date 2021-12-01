using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent), (typeof(Animator)))]
public class PlayerMover : MonoBehaviour
    {
        private NavMeshAgent _navMeshAgent;
        private Animator _animator;

        private void Update()
        {
            AnimController();
        }

        private void Start()
        {
            _navMeshAgent = GetComponent<NavMeshAgent>();
            _animator = GetComponent<Animator>();
        }

        public void MoveToCursor()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            var hasHit = Physics.Raycast(ray, out hit);
            if (hasHit)
            {
                _navMeshAgent.destination = hit.point;
            }
        }

        private void AnimController()
        {
            Vector3 velocity = _navMeshAgent.velocity;
            Vector3 localvelocity = transform.InverseTransformDirection(velocity);
            var speed = localvelocity.z;
            _animator.SetFloat("ForwardSpeed", speed);
        }
    }
    


