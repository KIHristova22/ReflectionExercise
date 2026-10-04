namespace ReflectionExercise.Attributes;
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]

public class RouteAttribute : Attribute
{
    public RouteAttribute(string template)
    {
        template = template;
    }

    public string Template { get;  } 
}