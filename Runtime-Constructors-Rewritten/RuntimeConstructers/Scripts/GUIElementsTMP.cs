using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RuntimeConstructers
{
    /// <summary>
    /// Factory class for creating TextMeshPro UI elements at runtime
    /// using TMP_DefaultControls and embedded Base64 default sprites.
    /// </summary>
    public class GUIElementsTMP : GUIElements
    {
        protected static TMP_DefaultControls.Resources TMPResources => new TMP_DefaultControls.Resources
        {
            standard = GetUISprite,
            background = GetBackground,
            inputField = GetInputFieldBackground,
            knob = GetKnob,
            checkmark = GetCheckmark,
            dropdown = GetDropdownArrow,
            mask = GetUIMask
        };

        /// <summary>
        /// Creates a TextMeshPro Button.
        /// </summary>
        public static Button ButtonTMP(GameObject canvas, Vector2 position, string text, float fontSize = 24f, string buttonName = "Button")
        {
            GameObject go = TMP_DefaultControls.CreateButton(TMPResources);
            TextMeshProUGUI label = go.GetComponentInChildren<TextMeshProUGUI>();
            if (label != null)
            {
                label.text = text;
                label.fontSize = fontSize;
            }
            return FinalizeControl<Button>(go, canvas, position, buttonName);
        }

        /// <summary>
        /// Creates a TextMeshProUGUI element.
        /// </summary>
        public static TextMeshProUGUI TextTMP(GameObject canvas, Vector2 position, string text, float fontSize = 36f, string textName = "Text (TMP)")
        {
            GameObject go = TMP_DefaultControls.CreateText(TMPResources);
            TextMeshProUGUI tmpText = go.GetComponent<TextMeshProUGUI>();
            tmpText.text = text;
            tmpText.fontSize = fontSize;
            return FinalizeControl<TextMeshProUGUI>(go, canvas, position, textName);
        }

        public static TextMeshProUGUI textTMP(GameObject Canvas, Vector2 position, string text, float fontSize = 36f, string TextName = "Text (TMP)") =>
            TextTMP(Canvas, position, text, fontSize, TextName);

        /// <summary>
        /// Creates a TextMeshPro InputField.
        /// </summary>
        public static TMP_InputField InputFieldTMP(GameObject canvas, Vector2 position, string inputFieldText = "", string inputFieldName = "InputField (TMP)")
        {
            GameObject go = TMP_DefaultControls.CreateInputField(TMPResources);
            TMP_InputField inputField = go.GetComponent<TMP_InputField>();
            inputField.text = inputFieldText;
            return FinalizeControl<TMP_InputField>(go, canvas, position, inputFieldName);
        }

        /// <summary>
        /// Creates a TextMeshPro Dropdown.
        /// </summary>
        public static TMP_Dropdown DropDownTMP(GameObject canvas, Vector2 position, string dropDownName = "Dropdown")
        {
            GameObject go = TMP_DefaultControls.CreateDropdown(TMPResources);
            return FinalizeControl<TMP_Dropdown>(go, canvas, position, dropDownName);
        }
    }
}
