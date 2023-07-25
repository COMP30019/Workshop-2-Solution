// COMP30019 - Graphics and Interaction
// (c) University of Melbourne, 2022

using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Helper class to sync the slider with the procedurally generated cone. Don't
// worry about how this works for now, we'll cover UI in a future workshop.
public class ConeSlider : MonoBehaviour
{
    [SerializeField] private GenerateCone cone;
    [SerializeField] private Slider coneSlider;
    [SerializeField] private TMP_Text coneSliderValueText;

    private void Update()
    {
        var numBaseVertices = this.cone.GetNumBaseVertices();
        this.coneSlider.value = numBaseVertices;
        this.coneSliderValueText.text = numBaseVertices.ToString();
    }
}
