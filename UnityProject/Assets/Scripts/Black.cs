using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    #region 練習區域 - 在此區域內練習

    [Header("血量")]
    public int Hp = 10;
    [Header("血量介面")]
    public Text TextHp;
    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip SoundHit;

    public void Hurt() {

        Hp = Hp - 1;
        TextHp.text = Hp.ToString();
        aud.PlayOneShot(SoundHit,1f);

        if (Hp <= 0)
        {
            Destroy(gameObject, 0.12f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "子彈") {
            Hurt();
        }
    }

    #endregion
}
