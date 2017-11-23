using UnityEngine;

public class Hud : Observer {

    private static Hud instance;
    public static Hud Instance
    {
        get
        {
            return instance;
        }
    }

    private GUIStyle font;
    private int humanCount;
    private int alienCount;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    private void Start()
    {
        font = new GUIStyle();
        font.fontSize = 20;
        font.normal.textColor = Color.yellow;
        humanCount = calculateTeamCount("Human");
        alienCount = calculateTeamCount("Alien");
    }

    private void OnGUI()
    {
        GUI.TextField(new Rect(25, 25, 400, 100), "Humans remaining: " + humanCount, font);
        GUI.TextField(new Rect(300, 25, 400, 100), "Aliens remaining: " + alienCount, font);
    }

    public override void OnNotify()
    {
        humanCount = calculateTeamCount("Human");
        alienCount = calculateTeamCount("Alien");
    }

    private int calculateTeamCount(string tag)
    {
        var gameObjects = GameObject.FindGameObjectsWithTag(tag);
        return gameObjects.Length;
    }
}
