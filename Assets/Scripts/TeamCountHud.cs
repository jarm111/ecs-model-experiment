using UnityEngine;
using UnityEngine.UI;

public class TeamCountHud : MonoBehaviour {

    //private GUIStyle font;
    private Text humansCount;
    private Text aliensCount;

    private void Start()
    {
        //font = new GUIStyle();
        //font.fontSize = 20;
        //font.normal.textColor = Color.yellow;
        TeamCount.Instance.OnTeamCountChange += OnTeamCountChange;
        humansCount = GameObject.Find("HumansCountText").GetComponent<Text>();
        aliensCount = GameObject.Find("AliensCountText").GetComponent<Text>();
        UpdateTextFields();
    }

    private void Update()
    {
        //humansCount.text = "Humans remaining: " + TeamCount.Instance.HumanCount;
        //aliensCount.text = "Aliens remaining: " + TeamCount.Instance.AlienCount;
    }

    private void OnGUI()
    {
        //GUI.TextField(new Rect(25, 25, 400, 100), "Humans remaining: " + TeamCount.Instance.HumanCount, font);
        //GUI.TextField(new Rect(300, 25, 400, 100), "Aliens remaining: " + TeamCount.Instance.AlienCount, font);
    }

    private void OnTeamCountChange()
    {
        UpdateTextFields();
    }

    private void UpdateTextFields()
    {
        humansCount.text = "Humans remaining: " + TeamCount.Instance.HumanCount;
        aliensCount.text = "Aliens remaining: " + TeamCount.Instance.AlienCount;
    }
}
