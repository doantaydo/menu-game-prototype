using UnityEngine;
using UnityEngine.UI;

public class popupMapNotUnlocked : MonoBehaviour
{
    public GameObject thisObject;
    int counter;
    void Awake() {
        counter = -1;
    }

    // Update is called once per frame
    void Update() {
        counter -= 1;
        thisObject.GetComponent<Image>().color = new Color(255,255,255,counter);
        if (counter <= 0) thisObject.SetActive(false);
    }
    public void ActiveObj() {
        counter = 255;
        thisObject.SetActive(true);
    }
}
