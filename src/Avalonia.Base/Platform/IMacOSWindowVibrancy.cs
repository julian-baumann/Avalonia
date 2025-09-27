using Avalonia.Metadata;

namespace Avalonia.Platform;

/// <summary>
/// Describes the available materials for macOS vibrancy effects.
/// </summary>
[Unstable]
public enum MacOSVibrancyMaterial
{
    AppearanceBased,
    Light,
    Dark,
    Titlebar,
    Selection,
    Menu,
    Popover,
    Sidebar,
    MediumLight,
    UltraDark,
    HeaderView,
    Sheet,
    WindowBackground,
    HudWindow,
    FullScreenUI,
    ToolTip,
    ContentBackground,
    UnderWindowBackground,
    UnderPageBackground,
    Glass
}

/// <summary>
/// Describes how a vibrancy effect reacts to the window activation state.
/// </summary>
[Unstable]
public enum MacOSVibrancyState
{
    FollowsWindowActiveState,
    Active,
    Inactive
}

/// <summary>
/// Describes the blending mode applied to the vibrancy effect.
/// </summary>
[Unstable]
public enum MacOSVibrancyBlendingMode
{
    BehindWindow,
    WithinWindow
}

/// <summary>
/// Provides access to macOS specific vibrancy configuration for a toplevel.
/// </summary>
[Unstable]
public interface IMacOSWindowVibrancy
{
    /// <summary>
    /// Applies vibrancy settings to the underlying native window.
    /// </summary>
    /// <param name="material">The desired vibrancy material. Null uses the platform default for the active transparency level.</param>
    /// <param name="state">The vibrancy activation state.</param>
    /// <param name="blendingMode">The vibrancy blending mode.</param>
    void SetVibrancy(MacOSVibrancyMaterial? material, MacOSVibrancyState state, MacOSVibrancyBlendingMode blendingMode);
}
