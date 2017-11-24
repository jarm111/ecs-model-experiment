using UnityEngine;

public class TeamCountDisplay : MonoBehaviour {

    private GUIStyle font;

    private void Start()
    {
        font = new GUIStyle();
        font.fontSize = 20;
        font.normal.textColor = Color.yellow;
    }

    private void OnGUI()
    {
        GUI.TextField(new Rect(25, 25, 400, 100), "Humans remaining: " + TeamCount.Instance.HumanCount, font);
        GUI.TextField(new Rect(300, 25, 400, 100), "Aliens remaining: " + TeamCount.Instance.AlienCount, font);
    }
}
