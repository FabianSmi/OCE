using TMPro;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    static public UI_Manager Instance;

    [SerializeField] TextMeshProUGUI HP;

    private void Awake()
    {
        if (Instance is not null)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void SetHpBar(float newhp)
    {
        HP.text = $"{newhp} HP";
    }
}
