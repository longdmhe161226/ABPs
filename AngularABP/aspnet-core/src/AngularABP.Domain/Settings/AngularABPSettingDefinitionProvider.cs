using Volo.Abp.Settings;

namespace AngularABP.Settings;

public class AngularABPSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AngularABPSettings.MySetting1));
    }
}
