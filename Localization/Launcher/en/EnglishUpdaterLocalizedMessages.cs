using MHLab.Patch.Core.Client.Localization;

namespace MHLab.Patch.Launcher.Wpf.Localization
{
    public sealed class EnglishUpdaterLocalizedMessages : IUpdaterLocalizedMessages
    {
        public string UpdateDownloadingArchive => "Downloading patch {0} to {1}...";
        public string UpdateDownloadedArchive => "Downloaded patch archive {0}_{1}.";
        public string UpdateDecompressingArchive => "Decompressing patch {0} to {1}...";
        public string UpdateDecompressedArchive => "Decompressed patch {0} to {1}.";
        public string UpdateUnchangedFile => "Unchanged file: {0}";
        public string UpdateProcessingNewFile => "Adding new file: {0}";
        public string UpdateProcessedNewFile => "Added new file: {0}";
        public string UpdateProcessingDeletedFile => "Deleting file: {0}";
        public string UpdateProcessedDeletedFile => "Deleted file: {0}";
        public string UpdateProcessingUpdatedFile => "Updating file: {0}";
        public string UpdateProcessedUpdatedFile => "Updated file: {0}";
        public string UpdateProcessingChangedAttributesFile => "Fixing file attributes: {0}";
        public string UpdateProcessedChangedAttributesFile => "Fixed file attributes: {0}";
        public string NotAvailableNetwork => "Network is not available or connectivity is low/weak... Check your connection!";
        public string NotAvailableServers => "Our servers are not responding... Wait some minutes and retry!";
        public string UpdateProcessCompleted => "Updating process completed successfully!";
        public string UpdateProcessFailed => "Updating process failed!";
        public string UpdateRestartNeeded => "A restart is needed!";
    }
}
