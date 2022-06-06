using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerLeft : MonoBehaviour
{
    Animator _scriptAnim;

    // Start is called before the first frame update
    void Start()
    {
        _scriptAnim = gameObject.GetComponent<Animator>();
        _scriptAnim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            _scriptAnim.enabled = !_scriptAnim.enabled;
        }
    }
}
