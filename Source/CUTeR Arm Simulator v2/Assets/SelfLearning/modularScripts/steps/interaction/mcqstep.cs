using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "LessonSteps/Interaction/mcq")]
public class mcqstep : LessonStep
{
    public string question;
    [Header("Add up to 4 options")]
    public List<string> options = new List<string>(4);
    public int correctoptionindex;

    private List<string> texts;
    [Header("Attach a image library and index if you want to show an image with the question")]
    public ImageLibrary imageLibrary;
    public int imageindex;
    public Vector2 size;
    private Sprite Image;
    private List<Sprite> image_sprite_list = new List<Sprite>();
    private void OnValidate()
    {
        // Enforce a max of 4 options
        if (options.Count > 4)
        {
            options.RemoveRange(4, options.Count - 4);
            Debug.LogWarning("Options list trimmed to max 4 entries.");
        }
    }

    public List<string> GetTexts()
    {
        if (texts == null || texts.Count == 0)
        {
            texts = new List<string>();
            texts.Add(question);
            texts.AddRange(options);
        }
        return texts;
    }
    public override IEnumerator Execute(LessonContext ctx)
    {
        texts= GetTexts();
        image_sprite_list = ctx.visuals.ConvertToSpriteList(imageLibrary.texture_list);
        Image = image_sprite_list[imageindex];
        yield return ctx.interactive.SetCompleteMC(texts, correctoptionindex, Image, size);
    }
}