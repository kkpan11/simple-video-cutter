﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleVideoCutter.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class GlobalStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GlobalStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SimpleVideoCutter.Properties.GlobalStrings", typeof(GlobalStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New version is available! Please visit project page..
        /// </summary>
        internal static string AboutBox_NewVersionAvailable {
            get {
                return ResourceManager.GetString("AboutBox_NewVersionAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Version.
        /// </summary>
        internal static string AboutBox_Version {
            get {
                return ResourceManager.GetString("AboutBox_Version", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are running the latest version. .
        /// </summary>
        internal static string AboutBox_VersionUpToDate {
            get {
                return ResourceManager.GetString("AboutBox_VersionUpToDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Question.
        /// </summary>
        internal static string GlobalQuestion {
            get {
                return ResourceManager.GetString("GlobalQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In order to use new language settings application needs to be restarted. Do you want to restart now?.
        /// </summary>
        internal static string MainForm_QuestionRestartNewLanguage {
            get {
                return ResourceManager.GetString("MainForm_QuestionRestartNewLanguage", resourceCulture);
            }
        }
    }
}
