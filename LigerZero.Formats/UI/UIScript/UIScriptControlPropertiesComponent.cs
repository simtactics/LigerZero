using System.ComponentModel;

namespace LigerZero.Formats.UI.UIScript;

[DisplayName("Set Control Properties")]
public class UIScriptControlPropertiesComponent : UIScriptComponentBase, IUIScriptNamedComponent
{
    public string Name { get; set; }
}