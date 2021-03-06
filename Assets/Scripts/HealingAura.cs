﻿using UnityEngine;

public class HealingAura : MonoBehaviour {

    [SerializeField]
    private float healingAmount = 1;

    private void OnTriggerStay2D(Collider2D collision)
    {
        var life = collision.GetComponent<Life>();
        if (life != null)
        {
            life.IncreaseHealth(healingAmount);
        }
    }
}
