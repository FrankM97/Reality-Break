using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script manipulates GUIs that are shaped like bars.
/// </summary>
/// <remarks>
///     Written by Jason Sorio.
/// </remarks>
/// <example>
/// Use this in any MonoBehaviour script.
/// <code>
/// 
/// public GameObject ValueBar;
/// ValueBarGUI guiScript;
/// 
/// void Start() {
///     guiScript = ValueBar.GetComponent<ValueBarGui>();
/// }
/// void FixedUpdate {
///     guiScript.DecreaseValue(2 * Time.deltaTime);
/// }
/// void OnCollisionEnter(Collision col) {
///     guiScript.IncreaseValue(10);
/// }
/// 
/// </code>
/// </example>

public class ValueBarGUI : MonoBehaviour
{
    RectTransform rectTransform;
    float initialWidth;
    
    [SerializeField]
    private float value = 100;

    /// <summary>
    /// The limit to how much ValueBarGUI's Value can increase.
    /// </summary>
    public float MaximumValue = 100;
    
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        initialWidth = rectTransform.rect.width;
        Value = value;
    }


    /// <summary>
    /// Adds to ValueBarGUI's value, and changes the GUI's size.
    /// </summary>
    /// <seealso cref="UpdateValue(float)"/>
    /// <param name="value">Adds ValueBarGUI's value by this value.</param>
    public void IncreaseValue(float value)
    {
        UpdateValue(value);
    }

    /// <summary>
    /// Subtracts to ValueBarGUI's value, and changes the GUI's size.
    /// </summary>
    /// <seealso cref="UpdateValue(float)"/>
    /// <param name="value">Subtracts ValueBarGUI's value by this value.</param>
    public void DecreaseValue(float value)
    {
        UpdateValue(-value);
    }

    /// <summary>
    /// Adds to ValueBarGUI's value, and changes the GUI's size.
    /// </summary>
    /// <seealso cref="IncreaseValue(float)"/>
    /// <seealso cref="DecreaseValue(float)"/>
    /// <param name="value">Adds ValueBarGUI's value by this value.</param>
    public void UpdateValue(float value)
    {
        Value += value;
    }

    /// <summary>
    /// Checks if Value = 0.
    /// </summary>
    /// <returns>Returns true if Value = 0.</returns>
    public bool IsEmpty()
    {
        return value <= 0 ? true : false;
    }

    /// <summary>
    /// Checks if Value = MaxValue.
    /// </summary>
    /// <returns>Returns true if Value = MaxValue.</returns>
    public bool IsFull()
    {
        return value >= MaximumValue ? true : false;
    }

    /// <summary>
    /// ValueBarGUI's current value.
    /// </summary>
    public float Value
    {
        get { return value; }
        set
        {
            this.value = Mathf.Clamp(value, 0, MaximumValue);
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, (this.value / MaximumValue) * initialWidth);
        }
    }
}
