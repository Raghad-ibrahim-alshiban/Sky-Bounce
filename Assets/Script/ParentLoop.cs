using UnityEngine;

public class ParentLoop : MonoBehaviour
{
    public float speed = 3f; // سرعة تحريك التلال
    public float width = 46.03f; // الرقم اللي حسبناه من طرح الـ X
    private Vector3 startPosition;

    void Start()
    {
        // حفظ مكان الأب عند تشغيل اللعبة
        startPosition = transform.position;
    }

    void Update()
    {
        // تحريك الأب بالكامل لليسار
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // أول ما الأب يمشي مسافة تساوي عرض تلة واحدة، يرجع لمكانه
        if (transform.position.x < startPosition.x - width)
        {
            transform.position = startPosition;
        }
    }
}