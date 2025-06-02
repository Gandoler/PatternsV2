namespace uLab4.Interpretators;

public class QuotesExpression:IExpression
{
    public void Interpret(Context context)
    {
        context.Text = context.Text.Replace("“", "«").Replace("”", "»");
    }
}