using UnityEngine;

public class Hud : MonoBehaviour {

    private GUIStyle font;

    private void Start()
    {
        font = new GUIStyle();
        font.fontSize = 20;
        font.normal.textColor = Color.yellow;
    }

    private void OnGUI()
    {
        GUI.TextField(new Rect(25, 25, 400, 100), "Humans remaining: " + calculateTeamCount("Human"), font);
        GUI.TextField(new Rect(300, 25, 400, 100), "Aliens remaining: " + calculateTeamCount("Alien"), font);
    }

    private int calculateTeamCount(string tag)
    {
        var gameObjects = GameObject.FindGameObjectsWithTag(tag);
        return gameObjects.Length;
    }
}
