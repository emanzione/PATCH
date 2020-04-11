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
    }
}
