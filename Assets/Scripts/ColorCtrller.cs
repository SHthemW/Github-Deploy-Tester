using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public sealed class ColorCtrller : MonoBehaviour
    {
        [SerializeField, Range(-0.1f, 0.1f)]
        private float _speedR;

        [SerializeField, Range(-0.1f, 0.1f)]
        private float _speedG;

        [SerializeField, Range(-0.1f, 0.1f)]
        private float _speedB;

        private Material _material;
        private Color _color;

        private void Awake()
        {
            _material = GetComponent<Renderer>().material;
        }

        private void Update()
        {
            UpdateColor();
            _material.color = _color;
        }

        private void UpdateColor()
        {
            var seed = UnityEngine.Random.Range(0, 3);

            switch (seed)
            {
                case 0:
                    _color.r += _speedR;
                    break; 
                case 1:
                    _color.g += _speedG;
                    break; 
                case 2:
                    _color.b += _speedB;
                    break;
            }

            if (_color.r >= 1 || _color.r <= 0)
                _speedR = -_speedR;

            if (_color.g >= 1 || _color.g <= 0)
                _speedG = -_speedG;

            if (_color.b >= 1 || _color.b <= 0)
                _speedB = -_speedB;
        }

    }
}
