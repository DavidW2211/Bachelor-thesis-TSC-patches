using UnityEngine;
using UnityEngine.EventSystems;

public class ExpandableMenu : MonoBehaviour
{
    [SerializeField] GameObject dropDownMenu;

    private Input_Actions inputActions;
    [HideInInspector]
    public bool hovered;

    // Start is called before the first frame update
    void Start()
    {
        inputActions = InputManager.instance.inputActions;
        inputActions.Player.MouseClick.performed += _ => OnMouseClickPerformed();
        inputActions.Player.Esc.performed += _ => OnEscPerformed();
    }

    private void OnEscPerformed()
    {
        Application.Quit();
    }

    public void OnMouseClickPerformed()
    {
        if (!hovered)
        {
            OnCloseDropDown();
        }
    }

    public void OnCloseDropDown()
    {
        dropDownMenu.SetActive(false);
        hovered = false;
    }

    public void OnOpenDropDown()
    {
        dropDownMenu.SetActive(true);
    }
}
