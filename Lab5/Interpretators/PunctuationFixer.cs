namespace uLab4.Interpretators;

public class PunctuationSpacingExpression:IExpression
{
    public void Interpret(Context context)
    {
        context.Text = System.Text.RegularExpressions.Regex.Replace(context.Text, @"\s+([\.,\)])", "$1");
        context.Text = System.Text.RegularExpressions.Regex.Replace(context.Text, @"\(\s+", "(");
    }
}