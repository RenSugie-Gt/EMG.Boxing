using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerbullet : MonoBehaviour
{
    public float destroyTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        // 3秒後に自動的に削除される
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
