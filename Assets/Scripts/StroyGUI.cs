using UnityEngine;
using System.Collections;

public class StroyGUI : MonoBehaviour
{

    public Texture2D talkBlock;
    public Texture2D Bili;

    public int fontSize;
    // public Font font;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        drawCharacter();
        drawTalkBlock();
        drawSubtitle();
    }

    private void drawCharacter()
    {
        GUI.DrawTexture(
            new Rect(
                Screen.width / 4, Screen.height / 4,
                Screen.width, Screen.height * 3 / 4),
            Bili, ScaleMode.ScaleToFit, true);
    }

    private void drawSubtitle()
    {
        var originColor = GUI.color;
        GUI.color = Color.black;
        GUI.skin.label.fontSize = fontSize;
        GUI.Label(subtitleRect, "比利：口中嚼著本體論，像失序的清教徒，是塞納河岸的詩。");
        GUI.color = originColor;
    }

    private void drawTalkBlock()
    {
        var originColor = GUI.color;
        GUI.color = new Color(1.0f, 1.0f, 1.0f, 0.75f);
        GUI.DrawTexture(talkBlockRect, talkBlock, ScaleMode.StretchToFill, true);
        GUI.color = originColor;
    }

    private Rect talkBlockRect
    {
        get
        {
            int x = Screen.width / 10;
            int y = Screen.height * 3 / 4;
            int width = Screen.width * 4 / 5;
            int height = Screen.height / 5;

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
