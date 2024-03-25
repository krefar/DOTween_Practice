using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorChanger : MonoBehaviour
{

    [SerializeField] private Color _color;
    [SerializeField] private float _duration;

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _spriteRenderer.DOColor(_color, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
