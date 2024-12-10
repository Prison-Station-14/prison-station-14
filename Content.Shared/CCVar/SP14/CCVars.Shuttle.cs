using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

public sealed partial class CCVars
{
    /// <summary>
    ///     The maximum <see cref="PhysicsComponent.Mass"/> a grid can have before it becomes unable to FTL.
    ///     Any value equal to or less than zero will disable this check.
    /// </summary>
    public static readonly CVarDef<float> FTLMassLimit =
        CVarDef.Create("shuttle.mass_limit", 700f, CVar.SERVERONLY);
}
