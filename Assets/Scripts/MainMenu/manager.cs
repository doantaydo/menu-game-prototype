using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene("SelectMap");
    }
    public void ExitGame() {
        Application.Quit();
    }
}
