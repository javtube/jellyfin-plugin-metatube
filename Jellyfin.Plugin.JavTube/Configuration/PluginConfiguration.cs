using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.JavTube.Configuration;

public class PluginConfiguration : BasePluginConfiguration
{
    #region General

    public string Server { get; set; } = "https://api.javtube.internal";

    public string Token { get; set; } = string.Empty;

    #endregion

    #region Trailer

    public bool EnableTrailers { get; set; } = false;

    #endregion

    #region GenreSubstitution

    public string GenreSubstitutionText { get; set; } = DefaultGenreSubstitutionText;

    private static string DefaultGenreSubstitutionText =>
        @"HD=
4K=
5K=
720p=
1080p=
60fps=";

    #endregion

    #region Translation

    public int TranslationMode { get; set; } = 0;

    public string TranslationEngine { get; set; } = "Baidu";

    public string BaiduAppId { get; set; } = string.Empty;

    public string BaiduAppKey { get; set; } = string.Empty;

    public string GoogleApiKey { get; set; } = string.Empty;

    #endregion
}