using MHLab.Patch.Core.Admin.Localization;

namespace MHLab.Patch.Admin.Localization
{
    public sealed class EnglishAdminLocalizedMessages : IAdminLocalizedMessages
    {
        public string NewVersionBuilding => "Building new {0} version...";
        public string BuildFileProcessed => "Processed file {0}.";
        public string BuildDefinitionProcessed => "Processed definition for {0}.";
        public string NewVersionBuilt => "New {0} version built.";
        public string VersionFileBuilding => "Building version file...";
        public string VersionFileBuilt => "Version file built.";
        public string BuildDefinitionBuilding => "Building build definition...";
        public string BuildDefinitionBuilt => "Build definition built.";
        public string BuildIndexBuilding => "Updating build index...";
        public string BuildCompletedSuccessfully => "Process completed! Version {0} ready!";

        public string PatchCollectingDefinitions => "Collecting builds definitions...";
        public string PatchCollectingPatchData => "Collecting patch data...";
        public string PatchCollectedPatchData => "Collected {0} data: {1}";
        public string PatchBuildingPatch => "Building patch {0}_{1}...";
        public string PatchSkippingFile => "Skipping files...";
        public string PatchAddingFile => "Adding {0} file...";
        public string PatchAddedFile => "Added {0} file.";
        public string PatchPatchingFile => "Generating diff for {0} file...";
        public string PatchPatchedFile => "Generated diff for {0} file.";
        public string PatchChangingAttributesFile => "Tracking attributes for {0} file...";
        public string PatchChangedAttributesFile => "Tracked attributes for {0} file.";
        public string PatchCompressing => "Compressing patch {0}_{1}...";
        public string PatchCompressed => "Compressed patch {0}_{1}.";
        public string PatchCleaningWorkspace => "Cleaning workspace from signature files...";
        public string PatchCleanedWorkspace => "Workspace is now clean.";
        public string PatchBuildingDefinition => "Building patch definition...";
        public string PatchBuiltDefinition => "Patch definition built successfully.";
        public string PatchBuildingIndex => "Updating patch index...";
        public string PatchBuiltIndex => "Patch index updated successfully.";
        public string UpdaterCollectingOldDefinition => "Collecting old definition...";
        public string UpdaterCollectingFiles => "Collecting new files...";
        public string UpdaterProcessedFile => "Processed file {0}";
        public string UpdaterCompressingArchive => "Compressing Launcher archive...";
        public string UpdaterCompressedArchive => "Compressed Launcher archive.";
        public string UpdaterSavedDefinition => "Saved Launcher update definition.";
    }
}
