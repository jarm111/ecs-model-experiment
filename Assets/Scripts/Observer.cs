﻿using UnityEngine;

public abstract class Observer : MonoBehaviour {

    public abstract void OnNotify(GameObject subject);
}
