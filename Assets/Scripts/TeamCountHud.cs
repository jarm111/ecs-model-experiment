using UnityEngine;
using UnityEngine.UI;

public class TeamCountHud : MonoBehaviour {

    private Text humansCount;
    private Text aliensCount;

    private void Start()
    {
        TeamCount.Instance.OnTeamCountChange += OnTeamCountChange;
        humansCount = GameObject.Find("HumansCountText").GetComponent<Text>();
        aliensCount = GameObject.Find("AliensCountText").GetComponent<Text>();
        UpdateTextFields();
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
