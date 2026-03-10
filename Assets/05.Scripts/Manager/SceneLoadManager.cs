using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : Singleton<SceneLoadManager>
{
    protected override bool IsDestroy => false;

    public void LoadScene(string sceneName)
    {
        StartCoroutine(Loading(sceneName));
    }

    private IEnumerator Loading(string sceneName)
    {
        SceneManager.LoadScene(Consts.SceneName.Loading);
        yield return null;

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        operation.allowSceneActivation = false;

        while (!operation.isDone)
        {
            // === 로딩 애니메이션 추가할 예정===

            if (operation.progress >= 0.9f)
            {
                operation.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
