using Content.Shared.Liberator;

namespace Content.Server.Liberator;

/// <summary>
/// System used for checking if the implanted is a Rev or Head Rev.
/// </summary>
public sealed class LiberatorConvertSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<LiberatorConvertEvent>(ConvertActor);
    }
    private void ConvertActor(LiberatorConvertEvent args)
    {
        Logger.Info("Event handled!");
    }
}
