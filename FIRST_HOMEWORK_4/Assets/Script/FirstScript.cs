using UnityEngine;

namespace KUMO
{
    /// <summary>
    /// �Ĥ@�ӵ{��
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region   
        // �Y�� �ֱ��� Tab
        // �榡�Ƥ�� Ctrl + K D
        // ������

        /*
         * �h�����
         * �h�����
        */
        #endregion
        #region �ƥ�ϰ�
        // ����ƥ� : �C���}�l�ɰ���@��
        private void Awake()
        {
            //��X(�T��);
            print("���o�A�U�w :D");  
        }
        
        // �}�l�ƥ� : �b Awake �����@��
        private void Start()
        {
            print("<color=red>�o�O�}�l�ƥ�</color>");
        }

        //��s�ƥ�:�b start �����A���榸�Ƭ� 60 FPS
        private void Update()
        {
            print("<color=orange>��s�ƥ�!</color>");
        }
        #endregion
    }
}