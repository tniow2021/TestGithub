using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()//������ �����ϸ� ó���� ���ѹ� ����Ǵ� ģ��
    {
        Debug.Log("��ŸƮ");
        int A = 4;
        int B = 8;
        Debug.Log(¦������(32768));
        
    }

    int ���ϱ�(int x,int y)
    {
        int ��ȯ�� = x * y;
        return ��ȯ��;
    }
    bool ¦������(int x)
    {
        bool ��;
        if(x % 2 == 0)
        {
            �� = true;
        }
        else
        {
            �� = false;
        }
        return ��;
    }

    int ��������;
    public float speed=40;
    public float JumpPower;
    // publix<-���� ,  Private(�⺻)<-�����
    // Update is called once per frame

    public Rigidbody2D rigid;
    void Update()//<-�������Ӹ��� ȣ��
    {
        
        //GetComponent<Rigidbody2D>().AddForce
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(new Vector2(0, JumpPower));
        }
        int �������� =0;
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime,0,0);//�̵��Լ�
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,-speed * Time.deltaTime, 0);//�̵��Լ�
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, speed * Time.deltaTime, 0, 0);//�̵��Լ�
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);//�̵��Լ�
        }

       
    }
}
