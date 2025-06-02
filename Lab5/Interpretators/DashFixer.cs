namespace uLab4.Interpretators;

public class DashExpression: IExpression
{
    public void Interpret(Context context)
    {
        context.Text = context.Text.Replace(" - ", " — ");
    }
}