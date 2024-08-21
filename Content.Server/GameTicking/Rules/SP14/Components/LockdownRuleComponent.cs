namespace Content.Server.GameTicking.Rules.Components;

[RegisterComponent, Access(typeof(LockdownRuleSystem))]
public sealed partial class LockdownRuleComponent : Component
{
    /// <summary>
    /// The gamerules that get added by lockdown.
    /// </summary>
    [DataField("additionalGameRules")]
    public HashSet<EntityUid> AdditionalGameRules = new();
}
