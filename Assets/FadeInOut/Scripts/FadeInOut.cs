using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeInOut : MonoBehaviour
{
    public static FadeInOut _instance;
    private Animator anim;
    public bool isFadeComplete;

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Fade()
    {
        anim.SetTrigger("Fade");
    }

    void  FadeComplete(bool b)
    {
        isFadeComplete = b;
    }

    public void GoScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
