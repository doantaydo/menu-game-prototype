using UnityEngine;
using UnityEngine.SceneManagement;

public class managerSelectLevel : MonoBehaviour
{
    public GameObject popup_not_unlock;
    public void Back() {
        SceneManager.LoadScene("MainMenu");
    }
    public void NotUnclock() {
        popup_not_unlock.GetComponent<popupMapNotUnlocked>().ActiveObj();
    }
}
