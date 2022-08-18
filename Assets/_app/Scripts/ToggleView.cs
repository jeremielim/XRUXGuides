using TMPro;
using UnityEngine;

public class ToggleView : MonoBehaviour
{
    public void ToggleVisibility(GameObject v)
    {
        v.SetActive(!v.activeSelf);
    }

    public void SetToggleText(TMP_Text buttonText)
    {
        buttonText.text = buttonText.text switch
        {
            "Show preview" => "Hide preview",
            "Hide preview" => "Show preview",
            _ => buttonText.text
        };
    }
}