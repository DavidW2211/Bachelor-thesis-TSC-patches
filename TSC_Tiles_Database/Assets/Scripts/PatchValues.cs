using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PatchValues : MonoBehaviour
{
    [Range(1, 5)] public int fabrEase;
    [Range(1, 5)] public int fabrSpeed;
    [Range(1, 5)] public int effectSize;
    [Range(1, 5)] public int scalability;
    [Range(1, 5)] public int robustness;
    [Range(1, 5)] public int surfaceTopo;

    public string protoName;

    [SerializeField] private bool b_Spike;
    [SerializeField] private bool b_Bump;
    [SerializeField] private bool b_Wave;
    [SerializeField] private bool b_Origami;
    [SerializeField] private bool b_Multimat;
    [SerializeField] private bool b_Metamat;
    [SerializeField] private bool b_OwnIdea;
    [SerializeField] private bool b_Convex;
    [SerializeField] private bool b_Concave;
    [SerializeField] private bool b_Bidirectional;
    [SerializeField] private bool b_Holes_Alw;
    [SerializeField] private bool b_Holes_Act;
    [SerializeField] private bool b_Closed;
    [SerializeField] private bool b_Spring;
    [SerializeField] private bool b_Straightening;
    [SerializeField] private bool b_Single;
    [SerializeField] private bool b_Multiple;
    [SerializeField] private bool b_Soft;
    [SerializeField] private bool b_Solid;
    [SerializeField] private bool b_Stretchable;
    [SerializeField] private bool b_3Dprint;
    [SerializeField] private bool b_Molding;
    [SerializeField] private bool b_Casting;

    [SerializeField] private string link;

    [HideInInspector]
    public ulong classiMask = 0;

    [SerializeField] private DetailWindow detailWindow;

    [SerializeField] private List<Sprite> images;

    private void Awake()
    {
        TMP_Text label = gameObject.GetComponentInChildren<TMP_Text>();
        label.text = protoName;
    }

    private void Start()
    {
        int bit = 0;

        if (b_Spike)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Bump)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Wave)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Origami)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Multimat)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Metamat)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_OwnIdea)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Convex)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Concave)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Bidirectional)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Holes_Alw)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Holes_Act)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Closed)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Spring)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Straightening)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Single)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Multiple)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Soft)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Solid)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Stretchable)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_3Dprint)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Molding)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
        if (b_Casting)
        {
            classiMask |= (ulong)1 << bit;
        }
        bit++;
    }

    public void OpenDetails()
    {
        detailWindow.fabrSpeedSlider.value = fabrSpeed;
        detailWindow.fabrEaseSlider.value = fabrEase;
        detailWindow.effectSizeSlider.value = effectSize;
        detailWindow.scalabilitySlider.value = scalability;
        detailWindow.robustnessSlider.value = robustness;
        detailWindow.surfaceTopoSlider.value = surfaceTopo;

        string temp = "";
        if (b_Spike)
        {
            temp += "Spike & ";
        }
        if (b_Bump)
        {
            temp += "Bump & ";
        }
        if (b_Wave)
        {
            temp += "Wave & ";
        }
        temp = temp.Substring(0, temp.Length - 2);
        detailWindow.shapeText.text = temp;

        temp = "";
        if (b_Origami)
        {
            temp += "Origami/Kirigami & ";
        }
        if (b_Multimat)
        {
            temp += "Multimaterial & ";
        }
        if (b_Metamat)
        {
            temp += "Metamaterial & ";
        }
        if (b_OwnIdea)
        {
            temp += "Other idea idea & ";
        }
        temp = temp.Substring(0, temp.Length - 2);
        detailWindow.approachText.text = temp;

        temp = "";
        if (b_Convex)
        {
            temp += "Convex & ";
        }
        if (b_Concave)
        {
            temp += "Concave & ";
        }
        if (b_Bidirectional)
        {
            temp += "Bidirectional & ";
        }
        temp = temp.Substring(0, temp.Length - 2);
        detailWindow.dirctionText.text = temp;

        temp = "";
        if (b_Holes_Alw)
        {
            temp += "Holes (Always) & ";
        }
        if (b_Holes_Act)
        {
            temp += "Holes (Actuated) & ";
        }
        if (b_Closed)
        {
            temp += "Closed & ";
        }
        temp = temp.Substring(0, temp.Length - 2);
        detailWindow.surfaceTopoText.text = temp;

        temp = "";
        if (b_Spring)
        {
            temp += "Spring & ";
        }
        if (b_Straightening)
        {
            temp += "Straightening & ";
        }
        temp = temp.Substring(0, temp.Length - 2);
        detailWindow.smaText.text = temp;

        temp = "";
        if (b_Single)
        {
            temp += "Single & ";
        }
        if (b_Multiple)
        {
            temp += "Multiple & ";
        }
        temp = temp.Substring(0, temp.Length - 2);
        detailWindow.layerStrucText.text = temp;

        temp = "";
        if (b_Soft)
        {
            temp += "Soft (TPU) & ";
        }
        if (b_Solid)
        {
            temp += "Solid (PLA) & ";
        }
        if (b_Stretchable)
        {
            temp += "Stretchable (Silicone) & ";
        }
        temp = temp.Substring(0, temp.Length - 2);
        detailWindow.materialText.text = temp;

        temp = "";
        if (b_3Dprint)
        {
            temp += "3D print & ";
        }
        if (b_Molding)
        {
            temp += "Molding & ";
        }
        if (b_Casting)
        {
            temp += "Casting & ";
        }
        temp = temp.Substring(0, temp.Length - 2);
        detailWindow.fabricText.text = temp;

        detailWindow.link.text = link;
        detailWindow.protoName.text = "Prototype: " + protoName;

        int maxImage = 4;

        foreach (Transform child in detailWindow.imageHolder.transform)
        {
            Destroy(child.gameObject);
        }

        float maxWidth = 1755;
        float currWidth = 0;

        foreach (Sprite item in images)
        {
            Vector2 spriteSize = item.rect.size;
            float reso = spriteSize.x / spriteSize.y;
            float width = 307 * reso;
            currWidth += width;
            if (currWidth > maxWidth)
            {
                break;
            }

            GameObject newObj = new GameObject();
            newObj.transform.parent = detailWindow.imageHolder.transform;
            newObj.AddComponent<Image>();
            RectTransform rectTrans = newObj.GetComponent<RectTransform>();
            rectTrans.sizeDelta = new Vector2(width, 307);
            rectTrans.localScale = new Vector3(0.8f, 0.8f, 1);
            Image objImage = newObj.GetComponent<Image>();
            objImage.sprite = item;

            maxImage--;
            if(maxImage <= 0)
            {
                break;
            }
        }

        detailWindow.gameObject.SetActive(true);
    }
}
