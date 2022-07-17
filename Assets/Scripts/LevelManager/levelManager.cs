using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {
    Scene scene;
    public GameObject panel;
    void Awake() {
        scene = SceneManager.GetActiveScene();
    }
    public void BackToSelectMap() {
        SceneManager.LoadScene("SelectMap");
    }
    public void ReplayGame() {
        SceneManager.LoadScene(scene.name);
    }
    public void LevelComplete() {
        PlayerPrefs.SetInt(scene.name, 1);
    }
    public void openPanel() {
        // Please set pause game condition at here
        panel.SetActive(true);
    }
    public void closePanel() {
        // Please set resume game condition at here
        panel.SetActive(false);
    }
}
