namespace MHLab.Patch.Core.Client.Localization
{
    public interface IUpdaterLocalizedMessages
    {
        string UpdateDownloadingArchive { get; }
        string UpdateDownloadedArchive { get; }
        string UpdateDecompressingArchive { get; }
        string UpdateDecompressedArchive { get; }


        string UpdateUnchangedFile { get; }
        string UpdateProcessingNewFile { get; }
        string UpdateProcessedNewFile { get; }
        string UpdateProcessingDeletedFile { get; }
        string UpdateProcessedDeletedFile { get; }
        string UpdateProcessingUpdatedFile { get; }
        string UpdateProcessedUpdatedFile { get; }
        string UpdateProcessingChangedAttributesFile { get; }
        string UpdateProcessedChangedAttributesFile { get; }
    }
}