using UnityEngine;

public class YDuzlemindeKameraTakip : MonoBehaviour
{
    public Transform karakter; // Takip edilecek karakterin transformu
    public float takipHiz = 2.0f; // Kamera takip hızı

    void LateUpdate()
    {
        if (karakter != null)
        {
            // Yeni pozisyonu oluştur ve sadece Y koordinatını karakterin Y koordinatı ile güncelle
            Vector3 newPosition = transform.position;
            newPosition.y = Mathf.Lerp(transform.position.y, karakter.position.y, takipHiz * Time.deltaTime);

            // Yeni pozisyonu kamera pozisyonu olarak ayarla
            transform.position = newPosition;
        }
    }
}