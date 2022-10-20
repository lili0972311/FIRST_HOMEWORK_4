using UnityEngine;

namespace KUMO
{
    /// <summary>
    /// ������� 2D �Ҧ�
    /// </summary>
    public class AirPlaneControler2D : MonoBehaviour
    {
        [Header("���ʳt��")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0,10)]
        private float speedHorizontal = 4f;
        [Header("�Ϥ�")]
        [SerializeField]
        private Sprite pictureUp;
        [SerializeField]        
        private Sprite pictureMiddle;
        [SerializeField]
        private Sprite pictureDown;

    }
}