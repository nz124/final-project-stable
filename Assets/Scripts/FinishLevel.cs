using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject finishLevelUI;
    public string nextLevelName;
    public float waitTimer = 5f;

    // Start is called before the first frame update

    void Start()
    {
        finishLevelUI.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(LoadNewLevel(nextLevelName));
        }
    }

    private IEnumerator LoadNewLevel(string newLevel)
    {
        finishLevelUI.SetActive(true);

        yield return new WaitForSeconds(waitTimer);

        SceneManager.LoadScene(newLevel);
    }
}