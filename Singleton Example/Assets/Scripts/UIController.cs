using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIController : MonoBehaviour {

    public TextMeshProUGUI text;

    private void Start()
    {
        text.SetText(string.Format("GameController was loaded {0} times", GameController.instance.currentLoad));
    }

    public void loadScene(int sceneIndex)
    {
        //GameController.instance.currentLoad++;
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
    }
}
