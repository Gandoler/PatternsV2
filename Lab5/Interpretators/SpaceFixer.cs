namespace uLab4.Interpretators;

public class MultiSpaceExpression :IExpression
{
    public void Interpret(Context context)
    {
        context.Text = System.Text.RegularExpressions.Regex.Replace(context.Text, @"[^\S\r\n]+", " ");
    }
}