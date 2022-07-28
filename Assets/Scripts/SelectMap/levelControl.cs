using UnityEngine;
using UnityEngine.SceneManagement;

public class levelControl : MonoBehaviour
{
    public GameObject previous_level, img_lock, img_unlock, img_complete;
    public GameObject popup_load_map;
    // this is name of the scene will be moved to when click in this level.
    public string level_name;
    public bool is_finish, is_lock;
    void Awake() {
        /// <summary>
        /// In action phase
        /// If player finish this level
        /// Please get obj "Manager" in screen
        /// Call "GetComponent<levelManager>().LevelComplete()"
        /// To save PlayerPrefs.SetInt(level_name,1)
        /// </summary>
        /// <returns></returns>
        PlayerPrefs.SetInt(level_name, 0); 
        is_finish = PlayerPrefs.GetInt(level_name, 0) == 1;
    }
    void Start() {
        // the map is completed
        if (is_finish == true) {
            img_complete.SetActive(true);
            img_lock.SetActive(false);
            img_unlock.SetActive(false);
            return;
        }
        img_complete.SetActive(false);

        // the first level doesn't have previous level
        if (previous_level == null) is_lock = false;
        // previous level will point to the object move to previous map
        // if previous level is completed, the next level will be unlocked
        else if (previous_level.GetComponent<levelControl>().is_finish == true) is_lock = false;
        else is_lock = true;

        // img_lock and unlock will point to the sprite objects that are included in the obj this script belongs to.
        img_lock.SetActive(is_lock);
        img_unlock.SetActive(!is_lock);
    }
    public void PopupLoadMap() {
        popup_load_map.SetActive(true);
    }
    public void cancelLoadMap() {
        popup_load_map.SetActive(false);
    }
    public void LoadMap() {
        SceneManager.LoadScene(level_name);
    }
}
