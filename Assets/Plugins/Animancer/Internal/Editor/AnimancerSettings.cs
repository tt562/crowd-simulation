// Animancer // https://kybernetik.com.au/animancer // Copyright 2021 Kybernetik //

#if UNITY_EDITOR

#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value.

using Animancer.Units;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Animancer.Editor
{
    /// <summary>[Editor-Only] Persistent settings used by Animancer.</summary>
    /// <remarks>
    /// This asset automatically creates itself when first accessed such as when opening the
    /// <see cref="Animancer.Editor.TransitionPreviewWindow"/> or viewing an <see cref="AnimationTimeAttribute"/>.
    /// <para></para>
    /// The default location is <em>Assets/Plugins/Animancer/Editor</em>, but you can freely move it (and the whole
    /// Animancer folder) anywhere in your project.
    /// <para></para>
    /// These settings can also be accessed in <see cref="AnimancerToolsWindow.Settings"/> panel in the
    /// <see cref="Animancer.Editor.AnimancerToolsWindow"/> (<c>Window/Animation/Animancer Tools</c>).
    /// </remarks>
    /// https://kybernetik.com.au/animancer/api/Animancer.Editor/AnimancerSettings
    /// 
    [HelpURL(Strings.DocsURLs.APIDocumentation + "." + nameof(Editor) + "/" + nameof(AnimancerSettings))]
    public sealed class AnimancerSettings : AnimancerSettingsInternal { }
}

#endif