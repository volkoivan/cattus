using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Collections;

public class EnemyMaker: MonoBehaviour {

    public GameObject Bird;

    private float curPatternTime = 0;
    private List<Pattern> patterns = new List<Pattern>(); 
	// Use this for initialization
	void Start () {
	    patterns.Add(GetPattern1());
        patterns.Add(GetPattern1());
	}
	
	// Update is called once per frame
	void Update () {
	    UpdatePattern();
	}

    private void UpdatePattern() {
        if (patterns.Any()) {
            var curPattern = patterns[0];
            if (curPattern.IsFinished) {
                patterns.RemoveAt(0);
                Debug.Log("Patterns count: " + patterns.Count());
                curPatternTime = 0;
                return;
            }

            curPatternTime += Time.deltaTime;
            curPattern.Logic(curPatternTime);

            if (curPattern.ToCreate.Any()) {
                foreach (var enemy in curPattern.ToCreate) {
                    Instantiate(enemy);
                }
                curPattern.ToCreate.Clear();    
            }
        }
    }

    public Pattern GetPattern1() {
        Pattern pt = new Pattern();
        pt.AddEnemy(Bird, 3);
        pt.AddEnemy(Bird, 8);
        return pt;
    }
}
