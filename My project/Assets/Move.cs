using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()//게임이 시작하면 처음에 딱한번 실행되는 친구
    {
        Debug.Log("스타트");
        int A = 4;
        int B = 8;
        Debug.Log(짝수판정(32768));
        
    }

    int 곱하기(int x,int y)
    {
        int 반환값 = x * y;
        return 반환값;
    }
    bool 짝수판정(int x)
    {
        bool 값;
        if(x % 2 == 0)
        {
            값 = true;
        }
        else
        {
            값 = false;
        }
        return 값;
    }

    int 전역변수;
    public float speed=40;
    public float JumpPower;
    // publix<-공개 ,  Private(기본)<-비공개
    // Update is called once per frame

    public Rigidbody2D rigid;
    void Update()//<-매프레임마다 호출
    {
        
        //GetComponent<Rigidbody2D>().AddForce
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(new Vector2(0, JumpPower));
        }
        int 지역변수 =0;
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime,0,0);//이동함수
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,-speed * Time.deltaTime, 0);//이동함수
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0, 0);//이동함수
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);//이동함수
        }

       
    }
}
