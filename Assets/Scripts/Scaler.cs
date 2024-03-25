using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _scaleTo;

    private void Start()
    {
        transform.DOScale(_scaleTo, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
