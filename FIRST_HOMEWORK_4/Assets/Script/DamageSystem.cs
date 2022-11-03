﻿using UnityEngine;

namespace KUMO
{
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;

        //碰撞開始事件 一次
        private void OnCollisionEnter2D(Collision2D collision)
        {
           // print("碰撞 : " + collision.gameObject);
           if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                //Destroy 刪除
                //gameobjet 此物件
                Destroy(gameObject);
            }

        }

        //碰撞離開事件 一次
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }

        //碰撞持續事件 一次
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }

}
