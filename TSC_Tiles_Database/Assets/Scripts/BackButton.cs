using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    [SerializeField] private GameObject detailCanvas;

    public void OnButtonClick()
    {
        detailCanvas.SetActive(false);
    }
}
