using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration;

    [SerializeField] private Text _text;

    private void Start()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Произошла замена", _duration))
            .Append(_text.DOText(", и добавление после", _duration).SetRelative())
            .Append(_text.DOText("Или подожди...", _duration, true, ScrambleMode.All))
            .SetLoops(-1);
    }
}
