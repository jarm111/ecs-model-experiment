using UnityEngine;

public class TeamCount : Observer {

    private static TeamCount instance;
    public static TeamCount Instance
    {
        get
        {
            return instance;
        }
    }

    private int humanCount;
    public int HumanCount
    {
        get
        {
            return humanCount;
        }
    }

    private int alienCount;
    public int AlienCount
    {
        get
        {
            return alienCount;
        }

        set
        {
            alienCount = value;
        }
    }

    public delegate void OnTeamCountChangeEvent();
    public event OnTeamCountChangeEvent OnTeamCountChange;

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

        humanCount = CalculateTeamCount("Human");
        alienCount = CalculateTeamCount("Alien");
    }

    public override void OnNotify(GameObject obj)
    {
        if (obj.CompareTag("Human")) {
            ReduceTeamCount(ref humanCount);
        }
        else if (obj.CompareTag("Alien"))
        {
            ReduceTeamCount(ref alienCount);
        }
    }

    private int CalculateTeamCount(string tag)
    {
        var gameObjects = GameObject.FindGameObjectsWithTag(tag);
        return gameObjects.Length;
    }

    private void ReduceTeamCount(ref int team)
    {
        team--;
        OnTeamCountChange();
    }
}
