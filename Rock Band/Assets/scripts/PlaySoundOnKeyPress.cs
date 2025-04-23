using UnityEngine;

public class PlaySoundOnKeyPress : MonoBehaviour
{
    public AudioClip clip; // Ҫ���ŵ���ƵƬ��
    public KeyCode keyToPress = KeyCode.Space; // �������ŵİ�����Ĭ���ǿո��

    private AudioSource audioSource;

    void Start()
    {
        // ���Ի�ȡ AudioSource ���
        audioSource = GetComponent<AudioSource>();

        // ���û�У����Զ����һ��
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        audioSource.playOnAwake = false;
        audioSource.clip = clip;
    }

    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            audioSource.Play();
        }
    }
}
