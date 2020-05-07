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
        public string NotAvailableNetwork => "Le réseau n'est pas disponible ou la connectivité est faible/faible... Vérifiez votre connexion!";
        public string NotAvailableServers => "Nos serveurs ne répondent pas... Attendez quelques minutes et réessayez!";
        public string UpdateProcessCompleted => "Le processus de mise à jour s'est terminé avec succès!";
        public string UpdateProcessFailed => "Échec du processus de mise à jour!";
        public string UpdateRestartNeeded => "Un redémarrage est nécessaire!";
    }
}
