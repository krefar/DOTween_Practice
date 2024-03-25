using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;

    private void Start()
    {
        transform.DOMove(_position, _duration).SetEase(Ease.Linear).SetDelay(_delay).SetLoops(-1, LoopType.Yoyo);
    }
}