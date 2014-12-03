using System.Threading;
using UnityEditor.VersionControl;
using UnityEngine;

public class ScaleChange : MonoBehaviour {
    private int Direction = 1;
    private int Speed = 40;
    // Use this for initialization
    private void Start() {
    }


    // Update is called once per frame
    private  void Update() {
        UpdateFont();

    }

    private void UpdateFont()
    {
        if (guiText.fontSize > 60)
        {
            Direction *= -1;
            guiText.fontSize = 60;
            Speed = 160;
        }
        if (guiText.fontSize < 50)
        {
            Direction *= -1;
            guiText.fontSize = 50;
            Speed = 1;
        }
        guiText.fontSize += Speed / 40 * Direction;
        Speed += 1;
    }

}