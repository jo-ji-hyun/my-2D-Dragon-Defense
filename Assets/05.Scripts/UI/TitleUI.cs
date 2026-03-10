using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleUI : MonoBehaviour
{
    [SerializeField] private Button startBtn;

    private void Start()
    {
        if(startBtn != null)
        {
            startBtn.onClick.AddListener(() => { SceneLoadManager.Instance.LoadScene(Consts.SceneName.Main); });
        }
    }
}
