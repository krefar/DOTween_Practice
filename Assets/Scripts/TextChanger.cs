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

        sequence.Append(_text.DOText("��������� ������", _duration))
            .Append(_text.DOText(", � ���������� �����", _duration).SetRelative())
            .Append(_text.DOText("��� �������...", _duration, true, ScrambleMode.All))
            .SetLoops(-1);
    }
}
