using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Pair<T, U>
{
    public Pair()
    {
    }

    public Pair(T first, U second)
    {
        this.First = first;
        this.Second = second;
    }

    public T First { get; set; }
    public U Second { get; set; }
};


public class FilterManager : MonoBehaviour
{
    //Large Bitmask for up to 50 filter criteria all set to true
    private ulong classiBitMask = 1125899906842623;

    public List<PatchValues> patchList;

    public List<Toggle> toggleList;
    private List<Pair<Toggle, int>> mappedToggle = new List<Pair<Toggle, int>>();


    //Slider
    [SerializeField] private Slider fabrSpeedSlider;
    [SerializeField] private Slider fabrEaseSlider;
    [SerializeField] private Slider effectSizeSlider;
    [SerializeField] private Slider scalabilitySlider;
    [SerializeField] private Slider robustnessSlider;
    [SerializeField] private Slider surfaceTopoSlider;

    private List<Slider> sliderList = new List<Slider>();

    //InputField
    [SerializeField] TMP_InputField mainInputField;
    string searchName = "";

    private void Start()
    {
        int counter = 0;

        foreach(Toggle item in toggleList)
        {
            var addToggle = new Pair<Toggle, int>(item, counter);
            mappedToggle.Add(addToggle);
            item.onValueChanged.AddListener(delegate {ToggleValueChanged(item);});
            counter++;
        }

        fabrSpeedSlider.onValueChanged.AddListener(delegate { SliderValueChanged(); });
        fabrEaseSlider.onValueChanged.AddListener(delegate { SliderValueChanged(); });
        effectSizeSlider.onValueChanged.AddListener(delegate { SliderValueChanged(); });
        scalabilitySlider.onValueChanged.AddListener(delegate { SliderValueChanged(); });
        robustnessSlider.onValueChanged.AddListener(delegate { SliderValueChanged(); });
        surfaceTopoSlider.onValueChanged.AddListener(delegate { SliderValueChanged(); });

        mainInputField.onValueChanged.AddListener(OnNameChanged);

        sliderList.Add(fabrSpeedSlider);
        sliderList.Add(fabrEaseSlider);
        sliderList.Add(effectSizeSlider);
        sliderList.Add(scalabilitySlider);
        sliderList.Add(robustnessSlider);
        sliderList.Add(surfaceTopoSlider);
    }

    public void OnNameChanged(string name)
    {
        searchName = name;
        refreshUI();
    }

    private void SliderValueChanged()
    {
        refreshUI();
    }

    private void ToggleValueChanged(Toggle change)
    {
        int id = 0;
        foreach(Pair<Toggle, int> item in mappedToggle)
        {
            if(item.First == change)
            {
                id = item.Second;
                Debug.Log("Toggle Found with id " + id);
                break;
            }
        }

        setClassification(change.isOn, id);
        refreshUI();
    }

    private void setClassification (bool active, int id){
        if (active)
        {
            classiBitMask |= (ulong)(1 << id);
        }
        else
        {
            classiBitMask &= ~(ulong)(1 << id);
        }
        Debug.Log("FilterBitMask: " + classiBitMask);
    }

    public void ResetCriteria()
    {
        foreach (Pair<Toggle, int> item in mappedToggle)
        {
            Toggle tog = item.First;
            tog.isOn = true;
            setClassification(true, item.Second);
        }

        foreach (Slider item in sliderList)
        {
            item.value = 1;
        }

        mainInputField.text = "";
        searchName = "";

        refreshUI();
    }


    private void refreshUI()
    {
        foreach(PatchValues item in patchList)
        {
            item.gameObject.SetActive(true);

            if (searchName != "")
            {
                if (item.protoName.IndexOf(searchName, StringComparison.InvariantCultureIgnoreCase) == -1)
                {
                    item.gameObject.SetActive(false);
                    continue;
                }
            }

            if (item.fabrSpeed < fabrSpeedSlider.value)
            {
                item.gameObject.SetActive(false);
                continue;
            }
            if (item.fabrEase < fabrEaseSlider.value)
            {
                item.gameObject.SetActive(false);
                continue;
            }
            if (item.effectSize < effectSizeSlider.value)
            {
                item.gameObject.SetActive(false);
                continue;
            }
            if (item.scalability < scalabilitySlider.value)
            {
                item.gameObject.SetActive(false);
                continue;
            }
            if (item.robustness < robustnessSlider.value)
            {
                item.gameObject.SetActive(false);
                continue;
            }
            if (item.surfaceTopo < surfaceTopoSlider.value)
            {
                item.gameObject.SetActive(false);
                continue;
            }

            Debug.Log("PatchBitMask: " + item.classiMask);
            ulong currMask = 0;
            int count = 0;

            while(currMask < classiBitMask)
            {
                currMask = (ulong) 1 << count;

                if(((classiBitMask & (ulong)(1 << count)) == 0) && ((item.classiMask & (ulong)(1 << count)) != 0))
                {
                    item.gameObject.SetActive(false);
                    break;
                }
                count++;
            }
        }

    }
}
