using UnityEngine;
using UnityEngine.UI; //UI ���� ���̺귯��
using UnityEngine.SceneManagement; //�� ���� ���� ���̺귯��

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText; //���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public Text timeText; //���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText; //�ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime; //���� �ð�
    private bool isGameover; //���ӿ��� ����


    void Start()
    {
        //���� �ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0;
        isGameover = false;
    }

    
    void Update()
    {
        
    }
    //���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    public void EndGame()
    {

    }

}
