using UnityEngine;

public class TeamCount : Observer {

    private static TeamCount instance;

    private int humanCount;
    private int alienCount;

    public delegate void OnTeamCountChangeEvent();
    public event OnTeamCountChangeEvent OnTeamCountChange;

    public static TeamCount Instance
    {
        get
        {
            return instance;
        }
    }

    public int HumanCount
    {
        get
        {
            return humanCount;
        }
    }


    public int AlienCount
    {
        get
        {
            return alienCount;
        }
    }

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

    public override void OnNotify(GameObject subject)
    {
        if (subject.CompareTag("Human")) {
            ReduceTeamCount(ref humanCount);
        }
        else if (subject.CompareTag("Alien"))
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
