﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CKY_Algorithm.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CKY_Algorithm.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to S -&gt; NP VP
        ///NP -&gt; Nam
        ///NP -&gt; Lan
        ///NP -&gt; CD NP
        ///NP -&gt; NP ADJP
        ///NP -&gt; sách
        ///NP -&gt; thư_viện
        ///NP -&gt; NP PP
        ///NP -&gt; UN NP
        ///NP -&gt; CD NP
        ///VP -&gt; VB NP
        ///VP -&gt; RB VP
        ///VP -&gt; VB VP
        ///VP -&gt; VP PP
        ///ADJP -&gt; RB JJ
        ///PP -&gt; IN NP
        ///VB -&gt; có
        ///VB -&gt; thích
        ///VB -&gt; đọc
        ///VB -&gt; đến
        ///VB -&gt; gặp
        ///VB -&gt; mượn
        ///RB -&gt; rất
        ///RB -&gt; thường_hay
        ///RB -&gt; thường
        ///CD -&gt; một
        ///UN -&gt; cuốn
        ///IN -&gt; ở
        ///IN -&gt; của
        ///JJ -&gt; hay.
        /// </summary>
        internal static string CNFRules {
            get {
                return ResourceManager.GetString("CNFRules", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Delete_32px {
            get {
                object obj = ResourceManager.GetObject("Delete_32px", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
