using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;
using System.Collections;

public class Pattern{
    public bool IsFinished = false;

    Dictionary<int, GameObject> _enemies = new Dictionary<int, GameObject>();
    public List<GameObject> ToCreate = new List<GameObject>();

    public void AddEnemy(GameObject enemy, int time) {
        _enemies.Add(time, enemy);
    }

    public void Logic(double patternTime) {
        if (!_enemies.Any() && !ToCreate.Any())
            IsFinished = true;

        foreach(KeyValuePair<int, GameObject> entry in _enemies)
        {
            if (entry.Key < patternTime) {
                Debug.Log("Some pattern call " + patternTime + " " + entry.Key);
                ToCreate.Add(entry.Value);
                _enemies.Remove(entry.Key);
            }
        }
    }
}
