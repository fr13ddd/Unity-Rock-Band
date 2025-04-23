using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyPressCounter : MonoBehaviour
{
    // ָ���ɱ�ͳ�Ƶİ���
    private readonly KeyCode[] targetKeys = new KeyCode[]
    {
        KeyCode.Q, KeyCode.W, KeyCode.E, KeyCode.R, KeyCode.T,
        KeyCode.Y, KeyCode.U, KeyCode.I, KeyCode.A, KeyCode.S,
        KeyCode.D, KeyCode.F, KeyCode.G, KeyCode.Z, KeyCode.X,
        KeyCode.C, KeyCode.V, KeyCode.B, KeyCode.N, KeyCode.M
    };

    public int requiredPressCount = 20; // ��Ҫ���Ĵ���
    public string nextSceneName;        // Ŀ�곡����

    private int currentCount = 0;

    void Update()
    {
        foreach (KeyCode key in targetKeys)
        {
            if (Input.GetKeyDown(key))
            {
                currentCount++;
                Debug.Log($"���� {key} �����£��ܴ�����{currentCount}");

                if (currentCount >= requiredPressCount)
                {
                    SceneManager.LoadScene(nextSceneName);
                }

                break; // ÿֻ֡ͳ��һ�ΰ���
            }
        }
    }
}
