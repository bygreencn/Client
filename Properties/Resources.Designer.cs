﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreeSquidClient.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FreeSquidClient.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap _interface {
            get {
                object obj = ResourceManager.GetObject("_interface", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://master.dl.sourceforge.net/project/china-badou/version/Hummingbird_squid.exe.
        /// </summary>
        internal static string myStringWebResource {
            get {
                return ResourceManager.GetString("myStringWebResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to      Squid Cache（简称为Squid）是HTTP代理服务器软件。Squid用途广泛的，可以作为缓存服务器，可以过滤流量帮助网络安全，也可以作为代理服务器链中的一环，向上级代理转发数据或直接连接互联网。Squid程序在Unix一类系统运行。由于它是开源软件，有网站修改Squid的源代码，编译为原生Windows版[3]；用户也可在Windows里安装Cygwin，然后在Cygwin里编译Squid。
        ///
        ///    Squid的发展历史相当悠久，功能也相当完善。除了HTTP外，对于FTP与HTTPS的支持也相当好，在3.0测试版中也支持了IPv6。但是Squid的上级代理不能使用SOCKS协议。
        ///
        /// Squid能在以下操作系统中运行：
        ///
        ///AIX
        ///BSDI
        ///Digital Unix
        ///FreeBSD
        ///HP-UX
        ///IRIX
        ///Linux
        ///Mac OS X
        ///NetBSD
        ///NeXTStep
        ///OpenBSD
        ///SCO OpenServer
        ///Solaris
        ///UnixWare
        ///Windows
        ///             -------------------------------- [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Squid {
            get {
                return ResourceManager.GetString("Squid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://master.dl.sourceforge.net/project/china-badou/version/app_version.xml.
        /// </summary>
        internal static string xmlURL {
            get {
                return ResourceManager.GetString("xmlURL", resourceCulture);
            }
        }
    }
}