using uLab4.Interpretators;

namespace uLab4;

public class TextInterpreterClient
{
    private readonly List<IExpression> _expressions;

    public TextInterpreterClient()
    {
        _expressions = new List<IExpression>
        {
            new MultiSpaceExpression(),
            new DashExpression(),
            new QuotesExpression(),
            new PunctuationSpacingExpression(),
            new NewlineExpression()
        };
    }

    public string Interpret(string input)
    {
        var context = new Context(input);
        foreach (var expr in _expressions)
            expr.Interpret(context);
        return context.Text;
    }
}