using System.Collections;
using UnityEngine;


public class Test : MonoBehaviour {

    //Bossクラス
    public class Boss
    {
        //初期MP
        private int mp = 53;

        //魔法攻撃関数
        public void Magic()
        {
            
            if (this.mp >= 5)
            {
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }
    }

    void Start()
    {
        //Bossクラスの実体化
        Boss magic = new Boss ();

        //配列初期化
        int[] array = { 0, 10, 20, 30, 40 };

        //昇順表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //降順表示
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //魔法を十回繰り返す
        for (int i = 0; i <= 10; i++)
        {
            magic.Magic();
        }
        
        
    }

    void Update()
    {
        
    }
}