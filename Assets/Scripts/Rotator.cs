using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _rotateTo;

    private void Start()
    {
        transform.DORotate(_rotateTo,_duration, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
    }
}