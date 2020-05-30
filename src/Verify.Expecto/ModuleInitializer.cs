using Expecto;

static class ModuleInitializer
{
    public static void Initialize()
    {
        InnerVerifier.Init(
            message => new AssertException(message),
            input => CounterContext.Current.IntOrNext(input),
            input => CounterContext.Current.IntOrNext(input),
            input => CounterContext.Current.IntOrNext(input));
    }
}