using UnityEngine;

namespace KUMO
{
    ///<summary>
    ///玩家發射
    /// </summary>
    
    public class PlayerFireSystem : FireSystemBase
    {
        //偵測玩家的輸入行為 : 鍵盤、滑鼠、觸控、搖桿
        private void Update()
        {

            //如果 按空白鍵 生成子彈
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }

        }

    }
}
