using UnityEngine;
using System.Collections;

public class StroyGUI : MonoBehaviour
{

    public Texture2D talkBlock;
    public Texture2D Bili;


    private float virtualWidth = 1920.0f;
    private float virtualHeight = 1080.0f;
    Matrix4x4 myGUIMatrix;

    public int fontSize;

    // Use this for initialization
    void Start()
    {
        myGUIMatrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity,
            new Vector3(Screen.width / virtualWidth,
                Screen.height / virtualHeight,
                1.0f));
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.matrix = myGUIMatrix;
        
        drawCharacter();
        drawTalkBlock();
        drawSubtitle();
    }

    private void drawCharacter()
    {
        GUI.DrawTexture(
            new Rect(480, 270, 1920, 810),
            Bili, ScaleMode.ScaleToFit, true);
    }

    private void drawSubtitle()
    {
        GUI.color = Color.black;
        GUI.skin.label.fontSize = fontSize;
        GUI.Label(subtitleRect, "比利：口中嚼著本體論，像失序的清教徒，是塞納河岸的詩。");
    }

    private void drawTalkBlock()
    {
        GUI.color = new Color(1.0f, 1.0f, 1.0f, 0.75f);
        GUI.DrawTexture(talkBlockRect, talkBlock, ScaleMode.StretchToFill, true);
    }

    private Rect talkBlockRect
    {
        get
        {
            float x = virtualWidth * 0.1f;
            float y = virtualHeight * 0.75f;
            float width = virtualWidth * 0.8f;
            float height = virtualHeight * 0.2f;

            return new Rect(x, y, width, height);
        }
    }

    private Rect subtitleRect
    {
        get
        {
            var tbr = talkBlockRect;
            return new Rect(
                tbr.x + 0.08f * tbr.width, tbr.y + 0.15f * tbr.height,
                tbr.width * 0.8f, tbr.height * 0.8f);
        }
    }
}
