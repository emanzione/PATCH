namespace MHLab.Patch.Core.Admin.Localization
{
    public interface IAdminLocalizedMessages
    {
        string NewVersionBuilding { get; }
        string BuildFileProcessed { get; }
        string BuildDefinitionProcessed { get; }
        string NewVersionBuilt { get; }
        string VersionFileBuilding { get; }
        string VersionFileBuilt { get; }
        string BuildDefinitionBuilding { get; }
        string BuildDefinitionBuilt { get; }
        string BuildIndexBuilding { get; }
        string BuildCompletedSuccessfully { get; }

        string PatchCollectingDefinitions { get; }
        string PatchCollectingPatchData { get; }
        string PatchCollectedPatchData { get; }
        string PatchBuildingPatch { get; }
        string PatchSkippingFile { get; }
        string PatchAddingFile { get; }
        string PatchAddedFile { get; }
        string PatchPatchingFile { get; }
        string PatchPatchedFile { get; }
        string PatchChangingAttributesFile { get; }
        string PatchChangedAttributesFile { get; }
        string PatchCompressing { get; }
        string PatchCompressed { get; }
        string PatchCleaningWorkspace { get; }
        string PatchCleanedWorkspace { get; }
        string PatchBuildingDefinition { get; }
        string PatchBuiltDefinition { get; }
        string PatchBuildingIndex { get; }
        string PatchBuiltIndex { get; }

        string UpdaterCollectingOldDefinition { get; }
        string UpdaterCollectingFiles { get; }
        string UpdaterProcessedFile { get; }
        string UpdaterCompressingArchive { get; }
        string UpdaterCompressedArchive { get; }
        string UpdaterSavedDefinition { get; }
    }
}
