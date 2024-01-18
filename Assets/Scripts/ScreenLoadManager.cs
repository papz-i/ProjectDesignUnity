using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoadManager : MonoBehaviour
{
    public FaderScreen faderScreen;

    public void GoToScene(string sceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(sceneIndex));
    }

    IEnumerator GoToSceneRoutine(string sceneIndex)
    {
        faderScreen.FadeOut();
        yield return new WaitForSeconds(faderScreen.fadeDuration);

        //Launch Scene
        SceneManager.LoadScene(sceneIndex);
    }
}
