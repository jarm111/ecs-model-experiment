using System;
using UnityEngine;

public class HpBar : MonoBehaviour
{
    [Serializable]
    public class HpBarProperties
    {
        public float yOffset = -.9f;
        public float xOffset = -0.0f;
        public float barWidth = 60f;
        public float barHeight = 8f;
    }

    [SerializeField]
    private Texture2D barBackground;
    [SerializeField]
    private Texture2D barForeground;
    [SerializeField]
    private HpBarProperties barProperties;
    private Life life;
    private float healthPercent;
    private Vector3 barPosition;

    private void Start()
    {
        life = GetComponent<Life>();
    }

    private void Update()
    {
        barPosition = Camera.main.WorldToScreenPoint(new Vector3(transform.position.x + barProperties.xOffset, 
            transform.position.y + barProperties.yOffset, transform.position.z));
        barPosition.y = Screen.height - barPosition.y;
        healthPercent = (float)life.CurrentHealth / (float)life.MaxHealth;
    }

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(barPosition.x - barProperties.barWidth / 2, barPosition.y, 
            barProperties.barWidth, barProperties.barHeight), barBackground, ScaleMode.StretchToFill);
        GUI.BeginGroup(new Rect(barPosition.x - barProperties.barWidth / 2, barPosition.y, 
            barProperties.barWidth * healthPercent, barProperties.barHeight));
        GUI.DrawTexture(new Rect(0, 0, barProperties.barWidth, barProperties.barHeight), 
            barForeground, ScaleMode.StretchToFill);
        GUI.EndGroup();
    }
}