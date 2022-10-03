using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DetailWindow : MonoBehaviour
{
    public Slider fabrSpeedSlider;
    public Slider fabrEaseSlider;
    public Slider effectSizeSlider;
    public Slider scalabilitySlider;
    public Slider robustnessSlider;
    public Slider surfaceTopoSlider;

    public TMP_Text protoName;

    public TMP_Text shapeText;
    public TMP_Text approachText;
    public TMP_Text dirctionText;
    public TMP_Text surfaceTopoText;
    public TMP_Text smaText;
    public TMP_Text layerStrucText;
    public TMP_Text materialText;
    public TMP_Text fabricText;

    public GameObject imageHolder;

    public TMP_Text link;
}
