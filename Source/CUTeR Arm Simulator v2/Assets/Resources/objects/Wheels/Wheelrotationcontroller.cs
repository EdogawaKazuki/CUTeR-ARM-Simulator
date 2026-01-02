using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;
public class Wheelrotationcontroller : MonoBehaviour
{
   // [SerializeField]
    //private List<VideoClip> videoClips = new List<VideoClip>();
    public GameObject Wheel;
    public GameObject Sphere;// Reference to the wheel GameObject
    public GameObject CW_Wheel;
    public GameObject CW_Caster;
    public GameObject CasterWheel;
    public GameObject Slider;
    public GameObject Chessboard;
    public VideoPlayer Videoplayer;
    //public VideoPlayer ToyCarVideo;
    public VideoPlayer CasterVideo;
    public RenderTexture NewRenderTexture;
    //public VideoClip clip = Resources.Load<VideoClip>("Videos/Sphero_Video");
    public List<VideoClip> clip;
    public GameObject Knight;
    public GameObject Bishop;
    public GameObject Prismatic;
    public GameObject Chess;
    public GameObject Screen;
    public RectTransform ScreenRect;
    public GameObject Canvas;
    public GameObject lesson4content;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float translationspeed = 1f;
    public float rotationspeed = 300f;
    public float rotationDuration = 5f;
    public Vector3 rotationaxis;
    private float timer = 0f;
    IEnumerator Wheelrotator()
    {
        //Debug.Log("Wheelrotator started");
        Wheel.transform.position = new Vector3(0f, -1.2f, 0f);
        Wheel.SetActive(true);
        float rotatedangle = 0f;
        float anglestep;
        rotationaxis = new Vector3(0, 0, 1);
        while (rotatedangle < 360f)
        {
            anglestep = rotationspeed * Time.deltaTime;
            Wheel.transform.Rotate(rotationaxis, anglestep);
            rotatedangle += anglestep;
            yield return null;
        }
        Wheel.SetActive(false);
        //rotationaxis = new Vector3(0, 0, 1);
        //while (timer < rotationDuration){
        //    Wheel.transform.Rotate(rotationaxis, rotationspeed * Time.deltaTime);
        //    yield return null;
        //    timer += Time.deltaTime;
        //}


    }

    IEnumerator SphereRotator()
    {
        Sphere.transform.position = new Vector3(0f, -1.2f, 0f);
        Sphere.SetActive(true);
        Vector3[] axes = { new Vector3(0, 1, 0), new Vector3(0, 0, 1), new Vector3(1, 0, 0) };
        foreach (var axis in axes)
        {
            //timer = 0f; // Reset timer for each axis
            float rotatedangle = 0f;
            float anglestep; // how much we rotate each frame

            while (rotatedangle < 360f)
            {
                anglestep = rotationspeed * Time.deltaTime;
                Sphere.transform.Rotate(axis, anglestep);
                rotatedangle += anglestep;
                yield return null; // Wait for the next frame
            }
            //while (timer < rotationDuration)

            // {
            //Sphere.transform.Rotate(axis, rotationspeed * Time.deltaTime);
            //yield return null;
            //timer += Time.deltaTime;
            //}
        }
       Sphere.SetActive(false);
    }


    IEnumerator CW_WRotator()
    {
        //Debug.Log("CW_WRotator started");
        CasterWheel.transform.position = new Vector3(0f, -1.2f, 0f);
        CasterWheel.SetActive(true);
        //CW_Wheel.SetActive(true);
        float rotatedangle = 0f;
        float anglestep;
        while (rotatedangle < 360)
        {
            anglestep = rotationspeed * Time.deltaTime;
            CW_Wheel.transform.Rotate(new Vector3(0, 1, 0), anglestep);
            rotatedangle += anglestep;
            yield return null;
        }
    }

    IEnumerator CW_CRotator()
    {
        CasterWheel.SetActive(true);
        //CW_Caster.SetActive(true);
        float rotatedangle = 0f;
        float anglestep;
        while (rotatedangle < 360)
        {
            anglestep = rotationspeed * Time.deltaTime;
            CW_Caster.transform.Rotate(new Vector3(0, 0, 1), anglestep);
            rotatedangle += anglestep;
            yield return null;
        }
        CasterWheel.SetActive(false);
    }
    IEnumerator Prismaticmotion()
    {
        Prismatic.transform.position = new Vector3(0f, -1.2f, 0f);
        Prismatic.SetActive(true);
        float distancestep;
        float sign = -1f;
        for (int i = 0; i < 4; i++)
        {
            sign *= -1f;
            float distancemoved = 0f;
            while (distancemoved < 2f)
            {
                distancestep = sign * translationspeed * Time.deltaTime;
                Slider.transform.Translate(new Vector3(0, distancestep, 0));
                distancemoved += Math.Abs(distancestep);
                yield return null;
            }
        }
        Prismatic.SetActive(false);
        //Slider.transform.Translate(new Vector3(0, -2, 0));
        //yield return null;
    }

    IEnumerator videoplayer(int n)
    {
        Videoplayer.clip = clip[n];
        //Debug.Log("Video Player is set to clip: " + video.clip.name);
        Videoplayer.Prepare();
        Videoplayer.Play();

        //while (Videoplayer.isPlaying)
        //{
        yield return new WaitForSeconds((float)Videoplayer.clip.length);
        Videoplayer.clip = null;
        yield return ClearToTransparent(NewRenderTexture);

        //Screen.SetActive(false);
        ////}

        //Videoplayer.Stop();


    }
    IEnumerator knightmove(string direction1, string direction2)
    {
        //Chessboard.SetActive(true);

        float distancestep = 0f;
        string[] directions = { direction1, direction2 };
        float[] distancetargets = { (float)((0.35 / 8) * 2 *20), (float)(0.35/8)*20 };
        for (int i = 0; i < directions.Length && i < distancetargets.Length; i++)
        {
            float moveddistance = 0f;
            while (moveddistance < distancetargets[i])
            {

                if (directions[i] == "up")
                {
                    distancestep = translationspeed * Time.deltaTime;
                    Knight.transform.Translate(new Vector3(0f, 0f, distancestep));
                }
                else if (directions[i] == "down")
                {
                    distancestep = -translationspeed * Time.deltaTime;
                    Knight.transform.Translate(new Vector3(0f, 0f, distancestep));
                }
                else if (directions[i] == "right")
                {
                    distancestep = translationspeed * Time.deltaTime;
                    Knight.transform.Translate(new Vector3(distancestep, 0f, 0f));
                }
                else if (directions[i] == "left")
                {
                    distancestep = -translationspeed * Time.deltaTime;
                    Knight.transform.Translate(new Vector3(distancestep, 0f, 0f));
                }
                moveddistance += Math.Abs(distancestep);
                yield return null;
            }
        }
    }

    IEnumerator bishopmove(string direction, int boxes)
    {
        float translationspeed2 = 5f;
        float moveddistance = 0f;
        float distancestep = 0f;
        while (moveddistance< ((0.35/8)*boxes * 20)){
            if (direction == "upright")
            {
                distancestep = translationspeed2 * Time.deltaTime;
                Bishop.transform.Translate(new Vector3(distancestep, 0f, distancestep));
            }
            else if (direction == "upleft")
            {
                distancestep = translationspeed2 * Time.deltaTime;
                Bishop.transform.Translate(new Vector3(-distancestep, 0f, distancestep));
            }
            else if (direction == "downright")
            {
                distancestep = translationspeed2 * Time.deltaTime;
                Bishop.transform.Translate(new Vector3(distancestep, 0f, -distancestep));
            }
            else if (direction == "downleft")
            {
                distancestep = translationspeed2 * Time.deltaTime;
                Bishop.transform.Translate(new Vector3(-distancestep, 0f, -distancestep));
            }
            else if (direction == "up")
            {
                distancestep = translationspeed2 * Time.deltaTime;
                Bishop.transform.Translate(new Vector3(0f, 0f, distancestep));
            }
            else if (direction == "down")
            {
                distancestep = translationspeed2 * Time.deltaTime;
                Bishop.transform.Translate(new Vector3(0f, 0f, -distancestep));
            }
            else if (direction == "left")
            {
                distancestep = translationspeed2 * Time.deltaTime;
                Bishop.transform.Translate(new Vector3(-distancestep, 0f, 0f));
            }
            else if (direction == "right")
            {
                distancestep = translationspeed2 * Time.deltaTime;
                Bishop.transform.Translate(new Vector3(distancestep, 0f, 0f));
            }

            moveddistance += distancestep;
            yield return null;
        }
    }
    IEnumerator knightcorrectmove()
    {
        Chess.SetActive(true);
        Knight.SetActive(true);
        yield return StartCoroutine(knightmove("down", "right"));
        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(knightmove("right", "down"));
        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(knightmove("left", "down"));
        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(knightmove("down", "left"));
        yield return new WaitForSeconds(3f);
        Knight.SetActive(false);
    }

    IEnumerator bishopcorrectmove()
    {
        Bishop.SetActive(true);
        yield return StartCoroutine(bishopmove("downright", 5));
        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(bishopmove("upright", 2));
        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(bishopmove("upleft", 3));
        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(bishopmove("downleft", 3));
        yield return new WaitForSeconds(3f);
        
    }

    IEnumerator bishopwrongmove()
    {
        yield return StartCoroutine(bishopmove("up", 1));
        yield return new WaitForSeconds(0.5f);
        yield return StartCoroutine(bishopmove("down", 1));
        yield return new WaitForSeconds(0.5f);
        yield return StartCoroutine(bishopmove("left", 1));
        yield return new WaitForSeconds(0.5f);
        yield return StartCoroutine(bishopmove("right", 1));
        yield return new WaitForSeconds(0.5f);
        yield return StartCoroutine(bishopmove("right", 1));
        yield return new WaitForSeconds(0.5f);
        yield return StartCoroutine(bishopmove("left", 1));
        yield return new WaitForSeconds(0.5f);
        yield return StartCoroutine(bishopmove("down", 1));
        yield return new WaitForSeconds(0.5f);
        yield return StartCoroutine(bishopmove("up", 1));
        yield return new WaitForSeconds(3f);
        Chess.SetActive(false);
    }
    //IEnumerator Sphere_VideoPlay()
    //{
    //    Screen.SetActive(true);
    //    Sphere.transform.position = new Vector3(-4.65f, 0.64f, 0f);
        
    //    Sphere.SetActive(true);
    //    StartCoroutine(videoplayer(0));
    //    StartCoroutine(SphereRotator());
    //    yield return null;
    //    if (Videoplayer.isPlaying == false)
    //    {
    //        StopCoroutine(SphereRotator());
    //    }      
    //}

   



    IEnumerator videosplaying()
    {
        
        Screen.SetActive(true);
        ScreenRect.rotation = Quaternion.Euler(0, 0, 90);
        Videoplayer.aspectRatio = VideoAspectRatio.FitHorizontally;
        Sphere.transform.position = new Vector3(-4.65f, 0.64f, 0f);
        Sphere.SetActive(true);
        yield return StartCoroutine(videoplayer(0));
        Sphere.SetActive(false);
        Wheel.transform.position = new Vector3(-4.65f, 0.64f, 0f);
        Wheel.SetActive(true);
        yield return StartCoroutine(videoplayer(1));
        Wheel.SetActive(false);
        Videoplayer.aspectRatio= VideoAspectRatio.FitVertically;
        CasterWheel.transform.position = new Vector3(-4.65f, 0.64f, 0f);
        CasterWheel.SetActive(true);
        ScreenRect.rotation = Quaternion.Euler(0,0,0);
        yield return StartCoroutine(videoplayer(2));
        CasterWheel.SetActive(false);
        Screen.SetActive(false);


    }
    IEnumerator ClearToTransparent(RenderTexture rt)
    {
        RenderTexture prev = RenderTexture.active; //save the active RenderTexture to a RenderTexture object named prev here
        RenderTexture.active = rt; //switch to my rt so i can clear it
        GL.Clear(true, true, Color.clear); // Color.clear = RGBA(0,0,0,0)
        RenderTexture.active = prev;
        yield return null;
    }


    public IEnumerator routine()
    {
        Screen.SetActive(true);
        //yield return StartCoroutine(videoplayer(0));
        yield return StartCoroutine(Wheelrotator());
        yield return StartCoroutine(SphereRotator());
        yield return StartCoroutine(CW_WRotator());
        yield return StartCoroutine(CW_CRotator());
        yield return StartCoroutine(Prismaticmotion());
        yield return StartCoroutine(videosplaying());
        yield return StartCoroutine(knightcorrectmove());
        yield return StartCoroutine(bishopcorrectmove());
        yield return StartCoroutine(bishopwrongmove());
        Canvas.SetActive(true);




        //videoplayer(ToyCarVideo);
        //videoplayer(CasterVideo);
    }
    public void OnStartButtonClicked()
    {
        Canvas.SetActive(false);
        lesson4content.SetActive(true);
        StartCoroutine(routine());
        
    }


// Update is called once per frame
void Update()
        {

        }
    
}
