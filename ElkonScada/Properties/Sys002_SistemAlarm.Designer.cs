﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElkonScada.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Sys002_SistemAlarm : global::System.Configuration.ApplicationSettingsBase {
        
        private static Sys002_SistemAlarm defaultInstance = ((Sys002_SistemAlarm)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Sys002_SistemAlarm())));
        
        public static Sys002_SistemAlarm Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UretimDurduAlarmSet {
            get {
                return ((bool)(this["UretimDurduAlarmSet"]));
            }
            set {
                this["UretimDurduAlarmSet"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool YeniUretimBasladiAlarmSet {
            get {
                return ((bool)(this["YeniUretimBasladiAlarmSet"]));
            }
            set {
                this["YeniUretimBasladiAlarmSet"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UretimeKaldigiYerdenDevamAlarmSet {
            get {
                return ((bool)(this["UretimeKaldigiYerdenDevamAlarmSet"]));
            }
            set {
                this["UretimeKaldigiYerdenDevamAlarmSet"] = value;
            }
        }
    }
}
