using System.Runtime.InteropServices;

using AlekseyNagovitsyn.BuildVision.Tool.Models.Settings;

namespace AlekseyNagovitsyn.BuildVision.Tool.Views.Settings
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [Guid("F7BF1C16-A1D4-4E93-9A10-9AE106D656EE")]
    public class GeneralSettingsDialogPage : SettingsDialogPage<GeneralSettingsControl, GeneralSettings>
    {
        protected override GeneralSettings Settings
        {
            get { return Package.ControlSettings.GeneralSettings; }
            set { Package.ControlSettings.GeneralSettings = value; }
        }
    }
}