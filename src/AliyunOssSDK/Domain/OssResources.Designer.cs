﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AliyunOssSDK.Domain {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    强类型资源类，用于查找本地化字符串，等等。
    /// </summary>
    // 此类已由 StronglyTypedResourceBuilder 自动生成
    // 通过 ResGen 或 Visual Studio 之类的工具提供的类。
    // 若要添加或删除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (使用 /str 选项)，或重新生成 VS 项目。
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class OssResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal OssResources() {
        }
        
        /// <summary>
        ///    返回此类使用的缓存 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AliyunOssSDK.Domain.OssResources", typeof(OssResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    重写所有项的当前线程的 CurrentUICulture 属性
        ///    使用此强类型资源类进行资源查找。
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
        ///    查找与 Bucket名称无效。Bucket 命名规范：
        ///1)只能包括小写字母，数字和短横线（-）；
        ///2)开头、结尾必须是小写字母或者数字；
        ///3)长度必须在 3-63 字节之间。 类似的本地化字符串。
        /// </summary>
        internal static string BucketNameInvalid {
            get {
                return ResourceManager.GetString("BucketNameInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///    查找与 不支持终结点给定的协议。仅支持HTTP/HTTPS协议，即终结点必须以&quot;http://&quot;或&quot;https://&quot;开头。 类似的本地化字符串。
        /// </summary>
        internal static string EndpointNotSupportedProtocal {
            get {
                return ResourceManager.GetString("EndpointNotSupportedProtocal", resourceCulture);
            }
        }
        
        /// <summary>
        ///    查找与 Object Key无效，长度必须大于0且不超过1023个字节。 类似的本地化字符串。
        /// </summary>
        internal static string ObjectKeyInvalid {
            get {
                return ResourceManager.GetString("ObjectKeyInvalid", resourceCulture);
            }
        }
    }
}