using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Item : MonoBehaviour
{
    Animator _anim;
    //AudioSource _audioSource;

    void Start()
    {
        _anim = GetComponent<Animator>();
        //_audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.V))
        //{
        //    _anim.Play("Idle");
        //}

        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    _anim.Play("Get");
        //}
    }

    /// <summary>
    /// 獲得アニメーションの再生が終わったら呼ぶ
    /// オブジェクトを破棄する
    /// </summary>
    void OnGetAnimationFinished()
    {
        Debug.Log("アイテムを破棄します");
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);
        Debug.Log(other.gameObject.name + " が接触した");
        // _anim.Play("Get");
        _anim.SetBool("IsGet", true);
        //_audioSource.Play();
        GetComponent<AudioSource>().Play();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " が離れた");
    }
}
