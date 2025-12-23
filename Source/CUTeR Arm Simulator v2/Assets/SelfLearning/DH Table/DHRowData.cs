using System;

[Serializable]
public class DHRowData
{
    public string LinkName;
    public float Theta;   // Joint angle (degrees or radians)
    public float D;       // Link offset
    public float A;       // Link length
    public float Alpha;   // Twist angle

    public DHRowData(string linkName = "Link", float theta = 0, float d = 0, float a = 0, float alpha = 0)
    {
        LinkName = linkName;
        Theta = theta;
        D = d;
        A = a;
        Alpha = alpha;
    }
}