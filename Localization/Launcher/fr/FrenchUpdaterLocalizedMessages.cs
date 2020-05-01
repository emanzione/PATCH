using MHLab.Patch.Core.Client.Localization;

namespace MHLab.Patch.Launcher.Wpf.Localization
{
    public sealed class FrenchUpdaterLocalizedMessages : IUpdaterLocalizedMessages
    {
        public string UpdateDownloadingArchive => "Téléchargement du patch {0} vers {1}...";
        public string UpdateDownloadedArchive => "Archive patch téléchargée {0}_{1}.";
        public string UpdateDecompressingArchive => "Décompression du patch {0} vers {1}...";
        public string UpdateDecompressedArchive => "Patch décompressé {0} vers {1}.";
        public string UpdateUnchangedFile => "Fichier inchangé : {0}";
        public string UpdateProcessingNewFile => "Ajout du fichier : {0}";
        public string UpdateProcessedNewFile => "Fichier ajouté : {0}";
        public string UpdateProcessingDeletedFile => "Suppression du fichier : {0}";
        public string UpdateProcessedDeletedFile => "Fichier supprimé : {0}";
        public string UpdateProcessingUpdatedFile => "Mise à jour du fichier : {0}";
        public string UpdateProcessedUpdatedFile => "Fichier mis à jour : {0}";
        public string UpdateProcessingChangedAttributesFile => "Correction des attributs du fichier : {0}";
        public string UpdateProcessedChangedAttributesFile => "Attributs corrigés : {0}";
    }
}
