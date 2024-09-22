using UnityEngine;
using TMPro;

public class PlayerThree : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;

    private int Age = 21;
    private int Height = 163;
    private float Weight = 102.4f;

    public void ButtonPressed()
    {
        m_Text.text = $"Name : Oh Haewon \n Country : Korea \n Blood Type : O \n Group : NMIXX \n Age: {Age} \n Height: {Height} \n Weight: {Weight}";
    }

}
