using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{

    protected GameManager GameManager => GameManager.Instance;          // GameManager �̱��� �ν��Ͻ��� �����Ѵ�.

    // Start is called before the first
    //
    // frame update
    void Start()
    {
        GameManager.OnGameStateChanged += updateUI;         // ���� ��ȭ�� ���� �Ǿ��� �� �ش� �Լ��� ȣ�� �Ѵ�.
    }

    private void OnDisable()                                // ���� ������Ʈ�� OFF�� �� ��
    {
        GameManager.OnGameStateChanged -= updateUI;         // ������ �̺�Ʈ�� �����Ѵ�.
    }

    private void updateUI(GameManager.GameState state)
    {
        switch(state)
        {
            case GameManager.GameState.Start:
                Debug.Log("���� ���� UI ������Ʈ");
                break;
            case GameManager.GameState.Playing:
                Debug.Log("���� �÷��� �� UI ������Ʈ");
                break;
            case GameManager.GameState.GameOver:
                Debug.Log("���� ���� UI ������Ʈ");
                break;
        }
    }

}
