using UnityEngine;
using UnityEngine.Video;
using System.Collections;
using Unity.VisualScripting;
public enum VideoModeType
{
    PlayFullVideo,
    Play_duration
}
public enum Endofvideo_Type
{
    Pause,
    Stop
}
public enum AspectRatio
{
    Horizontal,
    Vertical
}


[CreateAssetMenu(menuName = "LessonSteps/Video/VideoPlay")]
public class VideoPlayStep : LessonStep
{
    [Header("Reference the video clip library")]
    public VideoLibrary videoLibrary;
    [Header("Choose the video clip from the library")]
    public int videoIndex = 0;
    private int previousVideoIndex = -1;
    [Range(0f, 1f)]
    public float volume;
    [Range(-1f, 1f)]  // shows slider in Inspector
    public float horizontalposition;
    [Range(-1f, 1f)]  // shows slider in Inspector
    public float verticalposition;

    public AspectRatio aspectRatio = AspectRatio.Horizontal;
    [Header("Choose the video mode for playback")]
    public VideoModeType videoMode = VideoModeType.PlayFullVideo;
    public Endofvideo_Type endofvideoType = Endofvideo_Type.Stop;

    private void OnValidate()
    {
        if (videoLibrary != null && videoLibrary.videoClips != null &&
            videoIndex >= 0 && videoIndex < videoLibrary.videoClips.Count)
        {
            VideoClip clip = videoLibrary.videoClips[videoIndex];
            if (clip != null)
            {
                if (videoMode == VideoModeType.PlayFullVideo)
                    Duration = (float) clip.length; // Default to full length if invalid
            }
        }

        if (videoIndex >= 0)
            previousVideoIndex = videoIndex;
    }

    public override IEnumerator Execute(LessonContext ctx)
    {
        float height = videoLibrary.videoClips[videoIndex].height;
        float width = videoLibrary.videoClips[videoIndex].width;
        ctx.visuals.Screen.transform.localScale = new Vector3(1, height / width, 0);
        ctx.visuals.Videoplayer.clip = videoLibrary.videoClips[videoIndex];
        ctx.visuals.Screen.SetActive(true);
        float mappedX = Mathf.Lerp(-517f, 630f, (horizontalposition + 1f) / 2f);
        float mappedY = Mathf.Lerp(-70f,435f,(verticalposition + 1f) / 2f);

        // Keep the current Y and Z positions
        Vector3 screenPos = ctx.visuals.Screen.transform.localPosition;
        screenPos.x = mappedX;
        screenPos.y = mappedY;
        ctx.visuals.Screen.transform.localPosition = screenPos;
        switch (aspectRatio)
        {
            case AspectRatio.Horizontal:
                {
                    ctx.visuals.ScreenRect.rotation = Quaternion.Euler(0, 0, 90);
                    ctx.visuals.Videoplayer.aspectRatio = VideoAspectRatio.FitHorizontally;
                    break;
                }


            case AspectRatio.Vertical:
                {
                    ctx.visuals.ScreenRect.rotation = Quaternion.Euler(0, 0, 0);
                    ctx.visuals.Videoplayer.aspectRatio = VideoAspectRatio.FitVertically;
                    break;
                }
        }
        ctx.visuals.Videoplayer.Prepare();
        yield return new WaitUntil(() => ctx.visuals.Videoplayer.isPrepared);
        ctx.visuals.Videoplayer.SetDirectAudioVolume(0, volume);
        switch (videoMode)
        {
            case VideoModeType.PlayFullVideo:
                {
                    Debug.Log("Playing full video: " + videoLibrary.videoClips[videoIndex].name);
                    ctx.visuals.Videoplayer.Play();
                    yield return new WaitUntil(() => ctx.visuals.Videoplayer.isPlaying);
                    yield return new WaitForSeconds((float)ctx.visuals.Videoplayer.clip.length);
                    ctx.visuals.Videoplayer.Stop();
                    ctx.visuals.Videoplayer.clip = null;
                    yield return ctx.visuals.ClearToTransparent(ctx.visuals.NewRenderTexture);
                    ctx.visuals.Screen.SetActive(false);
                    break;

                }
            case VideoModeType.Play_duration:
                {
                    ctx.visuals.Screen.SetActive(true);
                    //Debug.Log("Playing video for " + playduration + " seconds.");
                    ctx.visuals.Videoplayer.Play();
                    Debug.Log("Playing video: " + videoLibrary.videoClips[videoIndex].name);
                    yield return new WaitUntil(() => ctx.visuals.Videoplayer.isPlaying);
                    yield return new WaitForSeconds(Duration);
                    switch (endofvideoType)
                    {
                        case Endofvideo_Type.Pause:
                            {
                                ctx.visuals.Videoplayer.Pause();
                                break;
                            }
                        case Endofvideo_Type.Stop:
                            {
                                ctx.visuals.Videoplayer.Stop();
                                ctx.visuals.Videoplayer.clip = null;
                                ctx.visuals.ClearToTransparent(ctx.visuals.NewRenderTexture);
                                ctx.visuals.Screen.SetActive(false);
                                break;
                            }
                    }
                    break;
                }

        }
    }
}