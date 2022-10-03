using UnityEngine;
using UnityEngine.EventSystems;

public class OnCursorHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private ExpandableMenu menu;

    public void OnPointerEnter(PointerEventData eventData)
    {
        menu.hovered = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        menu.hovered = false;
    }
}

