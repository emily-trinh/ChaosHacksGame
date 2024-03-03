using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] float timeBeforeTrans = 5.0f;
    public void Start()
    {
        StartCoroutine(loadNextScene());
    }
    IEnumerator loadNextScene()
    {
        yield return new WaitForSeconds(timeBeforeTrans);
        SceneManager.LoadScene("GameplayScene");
    }

}
