using UnityEngine;

namespace KUMO
{
    /// <summary>
    /// 學習欄位
    /// </summary>

    public class LearnField : MonoBehaviour
    {
        // 欄位 Field : 儲存資料
        // 語法 :
        // 修飾詞 資料類型 欄位名稱 ;
        // 私人 : private，僅在此類別內能夠存取，不顯示

        private int lv;

        // 等於 指定符號 : 將等號右邊的結果指定給左邊
        // 公開 : public，所有類別都能夠存取，顯示

        // 整數 int
        public int enemy = 5;

        // 浮點數 float
        public float speed = 3.5f;
        public float jump = 7.5f;

        // 字串 string
        public string namePlayer = "小騎士";

        // 布林值 bool
        public bool isPass = false;
        public bool hasWeapon = true;

        // 標題
        [Header("血量")]
        public int hp = 999;

        // 提示
        [Tooltip("玩家遊玩經過的時間。")]
        public float time = 10.5f;

        // 數值專用範圍(最小值，最大值)
        [Range(1, 99)]
        public int level = 10;
        [Range(2f, 10.5f)]
        public float walkSpeed = 3.5f;
        [Range(1, 100)]
        // 不支援 int 與 float 以外的資料類型
        public bool isOpen;

        // 序列化欄位 : 顯示私人欄位
        [SerializeField]
        private int countBoomb = 7;
    }
}
