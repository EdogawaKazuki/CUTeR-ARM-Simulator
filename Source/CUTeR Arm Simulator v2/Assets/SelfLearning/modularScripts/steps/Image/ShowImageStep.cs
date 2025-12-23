using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "LessonSteps/Image/ShowImage")]
public class ShowImageStep : LessonStep
{
    public ImageLibrary imageLibrary;
    public int imageindex;
    public Vector2 size;
    private Sprite Image;
    private List<Sprite> image_sprite_list = new List<Sprite>();

    public override IEnumerator Execute(LessonContext ctx)
    {
        Debug.Log("Executing ShowImageStep with image index: " + imageindex);
        image_sprite_list = ctx.visuals.ConvertToSpriteList(imageLibrary.texture_list);
        Image = image_sprite_list[imageindex];
        yield return ctx.visuals.SetImage(Image, size);
        ctx.visuals.SetImageStatus(true);
        yield return new WaitForSeconds(Duration);
        ctx.visuals.SetImageStatus(false);
    }
}