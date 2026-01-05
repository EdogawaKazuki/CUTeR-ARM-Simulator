using UnityEngine;

// This class holds the context for running a lesson, including references to various controls and the lesson runner itself.

public class LessonContext
{
    public RobotController robot;
    public GeneralRobotControl generalRobot;
    public GeneralAudioControl audio;
    public GeneralVisualControl visuals;
    public GeneralInteractiveControl interactive;
    public MonoBehaviour runner;
    public IntroductionTrajectorySelfLearning trajectoryScript;
    
}