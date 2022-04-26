using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class RandomMovement : MonoBehaviour
    {
        public float AccelerationTime = 0.2f;
        public float MaxSpeed = 10f;

        private Rigidbody _rb;
        private Vector2 _movement;
        private float _timeLeft;

        void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }
        void Update()
        {
            _timeLeft -= Time.deltaTime;
            if (_timeLeft <= 0)
            {
                _movement = new Vector2(UnityEngine.Random.Range(-1.5f, 1.5f), UnityEngine.Random.Range(-1.5f, 1.5f));
                _timeLeft += AccelerationTime;
            }
        }

        void FixedUpdate()
        {
            _rb.AddForce(_movement * MaxSpeed);
        }
    }
}
