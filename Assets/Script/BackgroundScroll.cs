using UnityEngine;

public class SeamlessScroll : MonoBehaviour
{ public float speed = 0.1f; // سرعة بطيئة جداً للسماء
    public float width = 20f;  // عرض صورة السماء الواحدة
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // تحريك مستمر لليسار
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // أول ما الصورة تقطع مسافة العرض، ترجع لمكانها
        // وبما أننا بنسوي نسختين، ماراح يبين الفرق
        if (transform.position.x < startPosition.x - width)
        {
            transform.position = startPosition;
        }
    }
}