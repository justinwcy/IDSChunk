namespace IDSChunk.Ingestion;

public interface IIngestionSource
{
    IEnumerable<CodeDocument> GetNewOrModifiedDocuments(IEnumerable<CodeDocument> existingDocuments);
    IEnumerable<CodeDocument> GetDeletedDocuments(IEnumerable<CodeDocument> existingDocuments);
    Task<IEnumerable<CodeChunk>> CreateChunksForDocument(CodeDocument document);
}
