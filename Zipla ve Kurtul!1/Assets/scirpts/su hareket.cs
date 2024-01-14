using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YukariHareket : MonoBehaviour
{
    // Kuklanın yukarı hareket hızı
    public float yukariHiz = 16f;

    // Update is called once per frame
    void Update()
    {
        // Yukarı doğru hareket et
        HareketEtYukari();
    }

    void HareketEtYukari()
    {
        // Y ekseninde yukarı doğru hareket et
        transform.Translate(Vector3.up * yukariHiz * Time.deltaTime);
    }
}
