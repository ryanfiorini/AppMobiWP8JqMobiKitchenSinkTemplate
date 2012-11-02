using AppMobiWP8JqMobiKitchenSinkTemplate.Resources;

namespace AppMobiWP8JqMobiKitchenSinkTemplate
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}