using UnityEngine;

namespace KUMO
{
    /// <summary>
    /// 第一個程式
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region   
        // 縮排 快捷鍵 Tab
        // 格式化文件 Ctrl + K D
        // 單行註解

        /*
         * 多行註解
         * 多行註解
        */
        #endregion
        #region 事件區域
        // 喚醒事件 : 遊戲開始時執行一次
        private void Awake()
        {
            //輸出(訊息);
            print("哈囉，沃德 :D");  
        }
        
        // 開始事件 : 在 Awake 後執行一次
        private void Start()
        {
            print("<color=red>這是開始事件</color>");
        }

        //更新事件:在 start 後執行，執行次數約 60 FPS
        private void Update()
        {
            print("<color=orange>更新事件!</color>");
        }
        #endregion
    }
}