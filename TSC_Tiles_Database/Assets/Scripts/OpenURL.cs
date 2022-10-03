using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class OpenURL : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TMP_Text urlText;
    [SerializeField] private Color32 baseCol;
    [SerializeField] private Color32 hoverCol;


    public void OnPointerEnter(PointerEventData eventData)
    {
        urlText.color = hoverCol;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        urlText.color = baseCol;
    }

    public void OpenStringURL()
    {
        string url = urlText.text;
        Application.OpenURL(url);
    }

}
