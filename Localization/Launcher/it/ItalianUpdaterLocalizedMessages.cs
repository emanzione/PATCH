using MHLab.Patch.Core.Client.Localization;

namespace MHLab.Patch.Launcher.Wpf.Localization
{
    public sealed class EnglishUpdaterLocalizedMessages : IUpdaterLocalizedMessages
    {
        public string UpdateDownloadingArchive => "Download della patch {0}_{1}...";
        public string UpdateDownloadedArchive => "Patch scaricata: {0}_{1}.";
        public string UpdateDecompressingArchive => "Decompressione della patch {0}_{1}...";
        public string UpdateDecompressedArchive => "Patch decompressa {0}_{1}.";
        public string UpdateUnchangedFile => "File invariato: {0}";
        public string UpdateProcessingNewFile => "Aggiunta di un nuovo file: {0}";
        public string UpdateProcessedNewFile => "Nuovo file aggiunto: {0}";
        public string UpdateProcessingDeletedFile => "Cancellazione di un file: {0}";
        public string UpdateProcessedDeletedFile => "File cancellato: {0}";
        public string UpdateProcessingUpdatedFile => "Aggiornamento di un file: {0}";
        public string UpdateProcessedUpdatedFile => "File aggiornato: {0}";
        public string UpdateProcessingChangedAttributesFile => "Aggiustamento degli attributi del file: {0}";
        public string UpdateProcessedChangedAttributesFile => "Attributi del file aggiustati: {0}";
    }
}
